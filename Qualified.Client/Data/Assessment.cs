using Newtonsoft.Json;
using System;

namespace Qualified.Data
{
	public class Assessment
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("defaultLanguage")]
		public string DefaultLanguage { get; set; }

		[JsonProperty("defaultInviteMessage")]
		public string DefaultInviteMessage { get; set; }

		[JsonProperty("teamId")]
		public string TeamId { get; set; }

		[JsonProperty("nounUpper")]
		public string NounUpper { get; set; }

		[JsonProperty("nounLower")]
		public string NounLower { get; set; }

		[JsonProperty("skipPracticeAssessment")]
		public bool? SkipPracticeAssessment { get; set; }

		[JsonProperty("inviteOnly")]
		public bool? InviteOnly { get; set; }

		[JsonProperty("softDeletedAt")]
		public DateTime? SoftDeletedAt { get; set; }

		[JsonProperty("enforcedTimeLimit")]
		public int? EnforcedTimeLimit { get; set; }

		[JsonProperty("manualEstimatedTime")]
		public int? ManualEstimatedTime { get; set; }

		[JsonProperty("suggestedEstimatedTime")]
		public int? SuggestedEstimatedTime { get; set; }

		[JsonProperty("copiedFromId")]
		public bool? CopiedFromId { get; set; }

		[JsonProperty("showSolutionsToCandidates")]
		public bool? ShowSolutionsToCandidates { get; set; }

		[JsonProperty("isTemplate")]
		public bool? IsTemplate { get; set; }

		[JsonProperty("isPractice")]
		public bool? IsPractice { get; set; }

		[JsonProperty("isDemo")]
		public bool? IsDemo { get; set; }

		[JsonProperty("galleryImage")]
		public string GalleryImage { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("challengeItems")]
		public ChallengeItem[] ChallengeItems { get; set; }

		[JsonProperty("activeAssessmentResultsCount")]
		public int? ActiveAssessmentResultsCount { get; set; }

		[JsonProperty("liveAssessmentResultsCount")]
		public int? LiveAssessmentResultsCount { get; set; }

		[JsonProperty("activeInvitationsCount")]
		public int? ActiveInvitationsCount { get; set; }

		[JsonProperty("accumulatedSecondsStats")]
		public Stats AccumulatedSecondsStats { get; set; }

		[JsonProperty("purpose")]
		public string Purpose { get; set; }

		[JsonProperty("demoLandingOrder")]
		public int? DemoLandingOrder { get; set; }

		[JsonProperty("scoreStats")]
		public Stats ScoreStats { get; set; }

		[JsonProperty("publishedAt")]
		public DateTime? PublishedAt { get; set; }

		[JsonProperty("archivedAt")]
		public DateTime? ArchivedAt { get; set; }

		[JsonProperty("createdAt")]
		public DateTime? CreatedAt { get; set; }

		[JsonProperty("assessmentResultsSummary")]
		public AssessmentResultsSummary AssessmentResultsSummary { get; set; }

		[JsonProperty("labels")]
		public string Labels { get; set; }

		[JsonProperty("notificationScheme")]
		public string NotificationScheme { get; set; }

		[JsonProperty("assignmentTeamMemberIds")]
		public string[] AssignmentTeamMemberIds { get; set; }

		[JsonProperty("redirectUrl")]
		public string RedirectUrl { get; set; }

		[JsonProperty("webhookUrl")]
		public string WebhookUrl { get; set; }

		[JsonProperty("submissionMessage")]
		public string SubmissionMessage { get; set; }

		[JsonProperty("assignmentLabels")]
		public string AssignmentLabels { get; set; }

		[JsonProperty("assignmentRole")]
		public string AssignmentRole { get; set; }

		[JsonProperty("workflowPaths")]
		public string[] WorkflowPaths { get; set; }
	}
}