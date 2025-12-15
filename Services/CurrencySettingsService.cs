using Microsoft.JSInterop;

namespace sandboxapp.Services
{
    /// <summary>
    /// Service for managing currency display settings
    /// Uses browser localStorage for persistence
    /// </summary>
    public class CurrencySettingsService
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly ILogger<CurrencySettingsService> _logger;

        private const string DISPLAY_CURRENCY_KEY = "ultimates_display_currency";
        private const string FX_RATE_SET_KEY = "ultimates_fx_rate_set";

        private string _displayCurrency = "GBP"; // Default to GBP
        private int _selectedFxRateSetId = 1; // Default to first rate set

        public event Action? OnSettingsChanged;

        public CurrencySettingsService(IJSRuntime jsRuntime, ILogger<CurrencySettingsService> logger)
        {
            _jsRuntime = jsRuntime;
            _logger = logger;
        }

        /// <summary>
        /// Gets the currently selected display currency (GBP or USD)
        /// </summary>
        public string DisplayCurrency => _displayCurrency;

        /// <summary>
        /// Gets the currently selected FX rate set ID
        /// </summary>
        public int SelectedFxRateSetId => _selectedFxRateSetId;

        /// <summary>
        /// Initialize settings from localStorage
        /// Should be called when component initializes
        /// </summary>
        public async Task InitializeAsync()
        {
            try
            {
                // Try to load display currency from localStorage
                var storedCurrency = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", DISPLAY_CURRENCY_KEY);
                if (!string.IsNullOrEmpty(storedCurrency) && (storedCurrency == "GBP" || storedCurrency == "USD"))
                {
                    _displayCurrency = storedCurrency;
                }

                // Try to load FX rate set from localStorage
                var storedRateSet = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", FX_RATE_SET_KEY);
                if (!string.IsNullOrEmpty(storedRateSet) && int.TryParse(storedRateSet, out int rateSetId))
                {
                    _selectedFxRateSetId = rateSetId;
                }

                _logger.LogInformation("Currency settings initialized: DisplayCurrency={DisplayCurrency}, FxRateSetId={FxRateSetId}",
                    _displayCurrency, _selectedFxRateSetId);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Error initializing currency settings from localStorage, using defaults");
                // Use defaults if there's an error
            }
        }

        /// <summary>
        /// Set the display currency (GBP or USD)
        /// </summary>
        public async Task SetDisplayCurrencyAsync(string currency)
        {
            if (currency != "GBP" && currency != "USD")
            {
                throw new ArgumentException("Display currency must be either GBP or USD", nameof(currency));
            }

            _displayCurrency = currency;

            try
            {
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", DISPLAY_CURRENCY_KEY, currency);
                _logger.LogInformation("Display currency changed to {Currency}", currency);
                OnSettingsChanged?.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving display currency to localStorage");
                throw;
            }
        }

        /// <summary>
        /// Set the selected FX rate set ID
        /// </summary>
        public async Task SetFxRateSetAsync(int fxRateSetId)
        {
            if (fxRateSetId <= 0)
            {
                throw new ArgumentException("FX rate set ID must be positive", nameof(fxRateSetId));
            }

            _selectedFxRateSetId = fxRateSetId;

            try
            {
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", FX_RATE_SET_KEY, fxRateSetId.ToString());
                _logger.LogInformation("FX rate set changed to {FxRateSetId}", fxRateSetId);
                OnSettingsChanged?.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving FX rate set to localStorage");
                throw;
            }
        }
    }
}
