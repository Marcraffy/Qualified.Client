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
		public string teamId { get; set; }

		[JsonProperty("State")]
		public string state { get; set; }

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
		public int? Score { get; set; }

		[JsonProperty("closedReason")]
		public string ClosedReason { get; set; }

		[JsonProperty("redirectUrl")]
		public string RedirectUrl { get; set; }

		[JsonProperty("submissionMessage")]
		public string SubmissionMessage { get; set; }

		[JsonProperty("nextAssessmentId")]
		public string NextAssessmentId { get; set; }

		[JsonProperty("totalSubmissionSeconds")]
		public int? TotalSubmissionSeconds { get; set; }

		[JsonProperty("totalOriginalSubmissionSeconds")]
		public int? TotalOriginalSubmissionSeconds { get; set; }

		[JsonProperty("accumulatedSeconds")]
		public int? AccumulatedSeconds { get; set; }

		[JsonProperty("enforcedTimeLimit")]
		public int? EnforcedTimeLimit { get; set; }

		[JsonProperty("timerExpiresIn")]
		public int? TimerExpiresIn { get; set; }

		[JsonProperty("wallTimeSinceStart")]
		public int? WallTimeSinceStart { get; set; }

		[JsonProperty("reopenedById")]
		public string ReopenedById { get; set; }

		[JsonProperty("activeTimedSolutionId")]
		public string ActiveTimedSolutionId { get; set; }

		[JsonProperty("isActiveInteractSession")]
		public bool? IsActiveInteractSession { get; set; }

		[JsonProperty("candidateName")]
		public string CandidateName { get; set; }

		[JsonProperty("candidateEmail")]
		public string CandidateEmail { get; set; }

		[JsonProperty("candidatePhone")]
		public string CandidatePhone { get; set; }

		[JsonProperty("interviewerIds")]
		public string[] InterviewerIds { get; set; }

		[JsonProperty("activeInterviewerIds")]
		public string[] ActiveInterviewerIds { get; set; }

		[JsonProperty("abandoned")]
		public bool? Abandoned { get; set; }

		[JsonProperty("workflowName")]
		public string WorkflowName { get; set; }

		[JsonProperty("isInteractSession")]
		public bool? IsInteractSession { get; set; }

		[JsonProperty("challengeItems")]
		public ChallengeItem[] ChallengeItems { get; set; }
	}
}