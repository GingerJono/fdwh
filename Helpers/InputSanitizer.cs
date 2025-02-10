using System.Text.Encodings.Web;

namespace Sandbox.Helpers
{
    public static class InputSanitizer
    {
        public static string SanitizeHtml(string? input)
        {
            input ??= string.Empty; 
            return HtmlEncoder.Default.Encode(input ?? "");
        }

        public static string UnsanitizeHtml(string? input)
        {
            input ??= string.Empty;
            return System.Web.HttpUtility.HtmlDecode(input ?? "");
        }
    }
}

