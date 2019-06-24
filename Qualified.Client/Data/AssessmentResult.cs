using Newtonsoft.Json;
using System;

namespace Qualified.Data
{
	public class AssessmentResult
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("assessmentIdid")]
		public string AssessmentId { get; set; }

		[JsonProperty("candidateIdid")]
		public string CandidateId { get; set; }

		[JsonProperty("teamCandidateId")]
		public string TeamCandidateId { get; set; }

		[JsonProperty("TeamId")]
		public string TeamId { get; set; }

		[JsonProperty("State")]
		public string State { get; set; }

		[JsonProperty("createdAt")]
		public DateTime? CreatedAt { get; set; }

		[JsonProperty("updatedAt")]
		public DateTime? UpdatedAt { get; set; }

		[JsonProperty("startedAt")]
		public DateTime? StartedAt { get; set; }

		[JsonProperty("invitedAt")]
		public DateTime? InvitedAt { get; set; }

		[JsonProperty("submittedAt")]
		public DateTime? SubmittedAt { get; set; }

		[JsonProperty("submittingAt")]
		public DateTime? SubmittingAt { get; set; }

		[JsonProperty("openedAt")]
		public DateTime? OpenedAt { get; set; }

		[JsonProperty("originalOpenedAt")]
		public DateTime? OriginalOpenedAt { get; set; }

		[JsonProperty("originalStartedAt")]
		public DateTime? OriginalStartedAt { get; set; }

		[JsonProperty("originalSubmittedAt")]
		public DateTime? OriginalSubmittedAt { get; set; }

		[JsonProperty("dryRun")]
		public bool? DryRun { get; set; }

		[JsonProperty("candidateRemarks")]
		public string CandidateRemarks { get; set; }

		[JsonProperty("score")]
		public double? Score { get; set; }

		[JsonProperty("closedReason")]
		public string ClosedReason { get; set; }

		[JsonProperty("redirectUrl")]
		public string RedirectUrl { get; set; }

		[JsonProperty("submissionMessage")]
		public string SubmissionMessage { get; set; }

		[JsonProperty("nextAssessmentId")]
		public string NextAssessmentId { get; set; }

		[JsonProperty("totalSubmissionSeconds")]
		public double? TotalSubmissionSeconds { get; set; }

		[JsonProperty("totalOriginalSubmissionSeconds")]
		public double? TotalOriginalSubmissionSeconds { get; set; }

		[JsonProperty("accumulatedSeconds")]
		public double? AccumulatedSeconds { get; set; }

		[JsonProperty("enforcedTimeLimit")]
		public double? EnforcedTimeLimit { get; set; }

		[JsonProperty("timerExpiresIn")]
		public double? TimerExpiresIn { get; set; }

		[JsonProperty("wallTimeSinceStart")]
		public double? WallTimeSinceStart { get; set; }

		[JsonProperty("reopenedById")]
		public string ReopenedById { get; set; }

		[JsonProperty("activeTimedSolutionId")]
		public string ActiveTimedSolutionId { get; set; }

		[JsonProperty("isActivedoubleeractSession")]
		public bool? IsActivedoubleeractSession { get; set; }

		[JsonProperty("candidateName")]
		public string CandidateName { get; set; }

		[JsonProperty("candidateEmail")]
		public string CandidateEmail { get; set; }

		[JsonProperty("candidatePhone")]
		public string CandidatePhone { get; set; }

		[JsonProperty("doubleerviewerIds")]
		public string[] doubleerviewerIds { get; set; }

		[JsonProperty("activedoubleerviewerIds")]
		public string[] ActivedoubleerviewerIds { get; set; }

		[JsonProperty("abandoned")]
		public bool? Abandoned { get; set; }

		[JsonProperty("workflowName")]
		public string WorkflowName { get; set; }

		[JsonProperty("isdoubleeractSession")]
		public bool? IsdoubleeractSession { get; set; }

		[JsonProperty("challengeItems")]
		public ChallengeItem[] ChallengeItems { get; set; }
	}
}