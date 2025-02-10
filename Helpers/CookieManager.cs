namespace Sandbox.Helpers
{
	public class CookieManager
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public CookieManager(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		public void SetCookie(string key, string value, int? expireDays)
		{
			CookieOptions option = new CookieOptions();

			if (expireDays.HasValue)
			{
				option.Expires = DateTime.Now.AddDays(expireDays.Value); // Set the cookie to expire in the specified number of days
			}
			else
			{
				option.Expires = DateTime.Now.AddDays(1); // Default to 1 day if no value is provided
			}

			_httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);
		}

		public string GetCookie(string key)
		{
			return _httpContextAccessor.HttpContext.Request.Cookies[key];
		}

		public void RemoveCookie(string key)
		{
			_httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
		}
	}
}
