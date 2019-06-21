using Newtonsoft.Json;

namespace Qualified
{
	public class StandardDeviationBounds
	{
		[JsonProperty("upper")]
		public double? Upper { get; set; }

		[JsonProperty("lower")]
		public double? Lower { get; set; }
	}
}