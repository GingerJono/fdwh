namespace sandboxapp.Utilities
{
    public static class CurrencyUtility
    {
        /// <summary>
        /// Gets the flag-icons CSS class for a given currency code (Windows-compatible)
        /// Returns classes like "fi fi-gb" for use with flag-icons library
        /// </summary>
        public static string GetCurrencyFlagClass(string currencyCode)
        {
            var countryCode = currencyCode?.ToUpper() switch
            {
                "GBP" => "gb", // United Kingdom
                "USD" => "us", // United States
                "EUR" => "eu", // European Union
                "JPY" => "jp", // Japan
                "AUD" => "au", // Australia
                "CAD" => "ca", // Canada
                "CHF" => "ch", // Switzerland
                "NZD" => "nz", // New Zealand
                "SGD" => "sg", // Singapore
                "HKD" => "hk", // Hong Kong
                "SEK" => "se", // Sweden
                "NOK" => "no", // Norway
                "DKK" => "dk", // Denmark
                "PLN" => "pl", // Poland
                "CNY" => "cn", // China
                "INR" => "in", // India
                "BRL" => "br", // Brazil
                "ZAR" => "za", // South Africa
                "MXN" => "mx", // Mexico
                "KRW" => "kr", // South Korea
                _ => "un"       // United Nations (default)
            };

            return $"fi fi-{countryCode}";
        }

        /// <summary>
        /// Gets the Unicode flag emoji for a given currency code (may not work on Windows)
        /// </summary>
        [Obsolete("Use GetCurrencyFlagClass for cross-platform support")]
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
