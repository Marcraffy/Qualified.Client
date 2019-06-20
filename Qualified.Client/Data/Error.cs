using Newtonsoft.Json;

namespace Qualified.Data
{
	public class Error
	{
		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("user")]
		public string User { get; set; }
	}
}