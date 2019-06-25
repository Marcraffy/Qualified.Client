using Newtonsoft.Json;

namespace Qualified.Data
{
	internal class SendAssessment
	{
		[JsonProperty("candidates")]
		public string[] Candidates { get; set; }

		[JsonProperty("assessment_id")]
		public string AssessmentId { get; set; }
	}
}