namespace sandboxapp.Utilities
{
    public static class CurrencyUtility
    {
        /// <summary>
        /// Gets the Unicode flag emoji for a given currency code
        /// </summary>
        public static string GetCurrencyFlag(string currencyCode)
        {
            return currencyCode?.ToUpper() switch
            {
                "GBP" => "🇬🇧", // United Kingdom
                "USD" => "🇺🇸", // United States
                "EUR" => "🇪🇺", // European Union
                "JPY" => "🇯🇵", // Japan
                "AUD" => "🇦🇺", // Australia
                "CAD" => "🇨🇦", // Canada
                "CHF" => "🇨🇭", // Switzerland
                "NZD" => "🇳🇿", // New Zealand
                "SGD" => "🇸🇬", // Singapore
                "HKD" => "🇭🇰", // Hong Kong
                "SEK" => "🇸🇪", // Sweden
                "NOK" => "🇳🇴", // Norway
                "DKK" => "🇩🇰", // Denmark
                "PLN" => "🇵🇱", // Poland
                "CNY" => "🇨🇳", // China
                "INR" => "🇮🇳", // India
                "BRL" => "🇧🇷", // Brazil
                "ZAR" => "🇿🇦", // South Africa
                "MXN" => "🇲🇽", // Mexico
                "KRW" => "🇰🇷", // South Korea
                _ => "🏳️"       // Default flag
            };
        }

        /// <summary>
        /// Gets the currency symbol for a given currency code
        /// </summary>
        public static string GetCurrencySymbol(string currencyCode)
        {
            return currencyCode?.ToUpper() switch
            {
                "GBP" => "£",
                "USD" => "$",
                "EUR" => "€",
                "JPY" => "¥",
                "AUD" => "A$",
                "CAD" => "C$",
                "CHF" => "CHF",
                "NZD" => "NZ$",
                "SGD" => "S$",
                "HKD" => "HK$",
                "SEK" => "kr",
                "NOK" => "kr",
                "DKK" => "kr",
                "PLN" => "zł",
                "CNY" => "¥",
                "INR" => "₹",
                "BRL" => "R$",
                "ZAR" => "R",
                "MXN" => "$",
                "KRW" => "₩",
                _ => currencyCode ?? ""
            };
        }

        /// <summary>
        /// Gets currency with flag, e.g., "🇬🇧 GBP"
        /// </summary>
        public static string GetCurrencyWithFlag(string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                return string.Empty;

            return $"{GetCurrencyFlag(currencyCode)} {currencyCode}";
        }

        /// <summary>
        /// Formats an amount with currency symbol
        /// </summary>
        public static string FormatAmount(decimal? amount, string currencyCode)
        {
            if (!amount.HasValue)
                return "-";

            var symbol = GetCurrencySymbol(currencyCode);

            // For GBP and EUR, put symbol before amount
            if (currencyCode == "GBP" || currencyCode == "EUR")
                return $"{symbol}{amount.Value:N0}";

            // For others, put symbol after (or use standard format)
            return $"{symbol}{amount.Value:N0}";
        }
    }
}
