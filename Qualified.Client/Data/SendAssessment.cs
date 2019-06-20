using Newtonsoft.Json;

namespace Qualified.Data
{
	public class SendAssessment
	{
		[JsonProperty("candidates")]
		public string[] Candidates { get; set; }

		[JsonProperty("assessment_id")]
		public string AssessmentId { get; set; }
	}
}