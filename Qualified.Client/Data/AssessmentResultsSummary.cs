using Newtonsoft.Json;

namespace Qualified
{
	public class AssessmentResultsSummary
	{
		[JsonProperty("_id")]
		public string Id { get; set; }

		[JsonProperty("all")]
		public int? All { get; set; }

		[JsonProperty("opened")]
		public int? Opened { get; set; }

		[JsonProperty("started")]
		public int? Started { get; set; }

		[JsonProperty("submitted")]
		public int? Submitted { get; set; }

		[JsonProperty("submitting")]
		public int? Submitting { get; set; }
	}
}