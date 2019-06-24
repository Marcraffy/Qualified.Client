using Newtonsoft.Json;

namespace Qualified.Data
{
	public class StandardDeviationBounds
	{
		[JsonProperty("upper")]
		public double? Upper { get; set; }

		[JsonProperty("lower")]
		public double? Lower { get; set; }
	}
}