using System.ComponentModel;

namespace Sandbox.Models.Reserving.Types
{
	public class SettCcyValueNew
	{
		public SettCcyEnum SettCcy { get; set; }
		private double _value;
		public double Value
		{
			get { return _value; }
			set
			{
				_value = value;
				OnValueChanged?.Invoke(this, EventArgs.Empty); // Trigger the event
			}
		}

		public double FXRate { get; set; }

		public double ValueInGBP
		{
			get
			{
				if (FXRate != 0)
				{
					return Value / FXRate;
				}
				return 0;
			}
		}

		private double _split;
		public double Split
		{
			get { return _split; }
			set
			{
				_split = value;
			}
		}

		public event EventHandler? OnValueChanged;
		public SettCcyValueNew DeepCopy()
		{
			var copy = new SettCcyValueNew
			{
				SettCcy = this.SettCcy,
				Value = this.Value,  // this will trigger the event; if you don't want to trigger it during copying, you might use the private field _value directly.
				FXRate = this.FXRate,
				Split = this.Split
			};
			// note that the event `OnValueChanged` is not copied. Typically events are not deeply copied because they reference external subscribers.
			return copy;
		}
	}

	public class SettCcySet
	{
		// Because it's in a view, the model gets "serialized/deserialized" by JSON to get sent to the client and back.
		// The serializer didn't know what to do with my private method.
		// Making it public meant it knew how to serialize it.
		private Dictionary<SettCcyEnum, SettCcyValueNew> _setValues = new();
		public Dictionary<SettCcyEnum, SettCcyValueNew> SetValues
		{
			get => _setValues;
			set => _setValues = value;
		}

		public string? SettCySetDescription { get; set; }

		public SettCcySet()
		{
			// required! "NotSupportedException: Deserialization of types without a parameterless constructor, a singular parameterized constructor,
			// or a parameterized constructor annotated with 'JsonConstructorAttribute' is not supported."
		}

		public SettCcySet(string description)
		{
			SettCySetDescription = description;

			foreach (var ccy in Enum.GetValues<SettCcyEnum>())
			{
				var settCcyValue = new SettCcyValueNew { SettCcy = ccy };
				settCcyValue.OnValueChanged += (sender, args) => UpdateSplits(); // Attach the event handler
				_setValues[ccy] = settCcyValue;
			}
		}

		// cosntructor with FX rates
		public SettCcySet(Dictionary<SettCcyEnum, double> fxRates, string description)
		{
			SettCySetDescription = description;

			foreach (var ccy in Enum.GetValues<SettCcyEnum>())
			{
				var settCcyValue = new SettCcyValueNew { SettCcy = ccy };
				settCcyValue.OnValueChanged += (sender, args) => UpdateSplits(); // Attach the event handler
				_setValues[ccy] = settCcyValue;

				if (fxRates.ContainsKey(ccy))
				{
					_setValues[ccy].FXRate = fxRates[ccy];
				}
			}
		}

		public static SettCcySet AddSettCcySets(SettCcySet set1, SettCcySet set2, string description)
		{
			SettCcySet newSet = new(description);

			if (set1 != null && set2 != null)
			{

				foreach (var settCcy in Enum.GetValues<SettCcyEnum>())
				{
					// Assume that both set1 and set2 have a value for every currency in SettCcyEnum
					double value1 = set1.SetValues[settCcy].Value;
					double value2 = set2.SetValues[settCcy].Value;

					// Perform addition
					double sumValue = value1 + value2;

					// Populate the new SettCcySet
					newSet.SetValues[settCcy].Value = sumValue;
					newSet.SetValues[settCcy].FXRate = set1.SetValues[settCcy].FXRate;
				}
			}

			return newSet;
		}
		public static SettCcySet ScaleSettCcySet(SettCcySet set1, double ScaleFactor, string description)
		{
			SettCcySet newSet = new(description);

			if (set1 != null)
			{
				foreach (var settCcy in Enum.GetValues<SettCcyEnum>())
				{
					// Assume that both set1 and set2 have a value for every currency in SettCcyEnum
					double value1 = set1.SetValues[settCcy].Value;

					// Perform addition
					double scaledValue = value1 * ScaleFactor;

					// Populate the new SettCcySet
					newSet.SetValues[settCcy].Value = scaledValue;
					newSet.SetValues[settCcy].FXRate = set1.SetValues[settCcy].FXRate;
				}

			}
			return newSet;
		}

		public static SettCcySet SubtractSettCcySets(SettCcySet set1, SettCcySet set2, string description)
		{
			SettCcySet newSet = new(description);

			if (set1 != null && set2 != null)
			{
				foreach (var settCcy in Enum.GetValues<SettCcyEnum>())
				{
					// Assume that both set1 and set2 have a value for every currency in SettCcyEnum
					double value1 = set1.SetValues[settCcy].Value;
					double value2 = set2.SetValues[settCcy].Value;

					// Perform addition
					double sumValue = value1 - value2;

					// Populate the new SettCcySet
					newSet.SetValues[settCcy].Value = sumValue;
					newSet.SetValues[settCcy].FXRate = set1.SetValues[settCcy].FXRate;
				}
			}

			return newSet;
		}

		public static SettCcySet AddMultipleSettCcySets(List<SettCcySet> sets, string description)
		{
			// Create a new SettCcySet for storing the summed values
			SettCcySet newSet = new(description);

			if (sets != null && sets.Count > 0)
			{

				// Loop through each currency type
				foreach (var settCcy in Enum.GetValues<SettCcyEnum>())
				{
					double sumValue = 0;

					// Loop through each SettCcySet in the list
					foreach (var set in sets)
					{
						if (set != null)
						{
							if (set.SetValues.ContainsKey(settCcy))
							{
								sumValue += set.SetValues[settCcy].Value;
							}
						}
					}

					// Populate the new SettCcySet with the summed value
					newSet.SetValues[settCcy].Value = sumValue;

					// Assuming the FX rate from the first set should be used
					if (sets.Any())
					{
						newSet.SetValues[settCcy].FXRate = sets.First().SetValues[settCcy].FXRate;
					}
				}
			}

			return newSet;
		}

		public SettCcySet DeepCopy(string description)
		{
			var copy = new SettCcySet(description);

			foreach (var key in _setValues.Keys)
			{
				copy.SetValues[key] = _setValues[key].DeepCopy();
			}

			// if there's any other state you need to copy, do it here
			return copy;
		}

		public SettCcyValueNew this[SettCcyEnum ccy] => _setValues[ccy];

		public double TotalValueInGBP
		{
			get
			{
				return _setValues.Values.Sum(item => item.ValueInGBP);
			}
		}

		public void UpdateSplits()
		{
			var totalValue = _setValues.Values.Sum(item => item.ValueInGBP);
			foreach (var item in _setValues.Values)
			{
				item.Split = totalValue != 0 ? item.ValueInGBP / totalValue : 0;
			}
		}
	}
}