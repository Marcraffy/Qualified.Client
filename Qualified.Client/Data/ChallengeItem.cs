using Newtonsoft.Json;

namespace Qualified
{
	public class ChallengeItem
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("challengeId")]
		public string ChallengeId { get; set; }

		[JsonProperty("disabledLanguages")]
		public string[] DisabledLanguages { get; set; }

		[JsonProperty("position")]
		public int? Position { get; set; }
	}
}