using sandboxapp.Models.Ultimates;

namespace sandboxapp.Services
{
    /// <summary>
    /// Service for performing currency conversions in the frontend
    /// Loads FX rates and caches them for performance
    /// </summary>
    public class FxConversionService
    {
        private readonly UltimatesService _ultimatesService;
        private readonly CurrencySettingsService _currencySettings;
        private readonly ILogger<FxConversionService> _logger;

        private Dictionary<string, decimal> _currentRates = new();
        private int _loadedRateSetId = -1;
        private bool _isLoading = false;

        public event Action? OnRatesLoaded;

        public FxConversionService(
            UltimatesService ultimatesService,
            CurrencySettingsService currencySettings,
            ILogger<FxConversionService> logger)
        {
            _ultimatesService = ultimatesService;
            _currencySettings = currencySettings;
            _logger = logger;

            // Subscribe to settings changes to reload rates when FX rate set changes
            _currencySettings.OnSettingsChanged += async () => await LoadRatesAsync();
        }

        /// <summary>
        /// Load FX rates for the currently selected rate set
        /// </summary>
        public async Task LoadRatesAsync()
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;
                var rateSetId = _currencySettings.SelectedFxRateSetId;

                // Only reload if rate set has changed
                if (_loadedRateSetId == rateSetId && _currentRates.Count > 0)
                {
                    return;
                }

                _logger.LogInformation("Loading FX rates for rate set {RateSetId}", rateSetId);

                var rates = await _ultimatesService.GetFxRates(fxRateSetId: rateSetId);

                // Build a dictionary for fast lookups: "FROM_TO" -> rate
                _currentRates = rates.ToDictionary(
                    r => $"{r.FromCurrency}_{r.ToCurrency}",
                    r => r.Rate
                );

                _loadedRateSetId = rateSetId;

                _logger.LogInformation("Loaded {Count} FX rates for rate set {RateSetId}",
                    _currentRates.Count, rateSetId);

                OnRatesLoaded?.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error loading FX rates");
                throw;
            }
            finally
            {
                _isLoading = false;
            }
        }

        /// <summary>
        /// Convert an amount from one currency to another
        /// </summary>
        public decimal? Convert(decimal? amount, string fromCurrency, string toCurrency)
        {
            if (!amount.HasValue || amount.Value == 0)
                return amount;

            if (string.IsNullOrWhiteSpace(fromCurrency) || string.IsNullOrWhiteSpace(toCurrency))
                return amount;

            // No conversion needed
            if (fromCurrency.Equals(toCurrency, StringComparison.OrdinalIgnoreCase))
                return amount;

            // Look up the rate
            var key = $"{fromCurrency.ToUpper()}_{toCurrency.ToUpper()}";
            if (_currentRates.TryGetValue(key, out var rate))
            {
                return amount.Value * rate;
            }

            _logger.LogWarning("FX rate not found for {FromCurrency} to {ToCurrency}", fromCurrency, toCurrency);
            return amount; // Return original amount if rate not found
        }

        /// <summary>
        /// Convert to the display currency selected by the user
        /// </summary>
        public decimal? ConvertToDisplayCurrency(decimal? amount, string fromCurrency)
        {
            return Convert(amount, fromCurrency, _currencySettings.DisplayCurrency);
        }

        /// <summary>
        /// Format an amount in the display currency with symbol
        /// </summary>
        public string FormatInDisplayCurrency(decimal? amount, string fromCurrency)
        {
            var converted = ConvertToDisplayCurrency(amount, fromCurrency);

            if (!converted.HasValue)
                return "-";

            var symbol = _currencySettings.DisplayCurrency == "GBP" ? "£" : "$";
            return $"{symbol}{converted.Value:N0}";
        }

        /// <summary>
        /// Get the display currency symbol
        /// </summary>
        public string GetDisplayCurrencySymbol()
        {
            return _currencySettings.DisplayCurrency == "GBP" ? "£" : "$";
        }

        /// <summary>
        /// Check if rates are loaded
        /// </summary>
        public bool AreRatesLoaded()
        {
            return _currentRates.Count > 0;
        }
    }
}
