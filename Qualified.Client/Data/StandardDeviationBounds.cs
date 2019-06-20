using Newtonsoft.Json;

namespace Qualified
{
	public class StandardDeviationBounds
	{
		[JsonProperty("upper")]
		public int? Upper { get; set; }

		[JsonProperty("lower")]
		public int? Lower { get; set; }
	}
}