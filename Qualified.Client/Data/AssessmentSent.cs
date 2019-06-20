using Newtonsoft.Json;
using System;

namespace Qualified.Data
{
	public class AssessmentSent
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("teamCandidateId")]
		public string TeamCandidateId { get; set; }

		[JsonProperty("assessmentId")]
		public string AssessmentId { get; set; }

		[JsonProperty("assessmentResultId")]
		public string AssessmentResultId { get; set; }

		[JsonProperty("teamId")]
		public string TeamId { get; set; }

		[JsonProperty("teamMemberId")]
		public string TeamMemberId { get; set; }

		[JsonProperty("sendEmailToCandidate")]
		public bool? SendEmailToCandidate { get; set; }

		[JsonProperty("sendEmailToInviter")]
		public bool? SendEmailToInviter { get; set; }

		[JsonProperty("expiresAt")]
		public DateTime? ExpiresAt { get; set; }

		[JsonProperty("reminderAt")]
		public DateTime? ReminderAt { get; set; }

		[JsonProperty("reminded")]
		public bool? Reminded { get; set; }

		[JsonProperty("invitedByAssessmentTitle")]
		public bool? InvitedByAssessmentTitle { get; set; }

		[JsonProperty("invitedByWorkflowLabel")]
		public bool? InvitedByWorkflowLabel { get; set; }

		[JsonProperty("assessmentTitle")]
		public string AssessmentTitle { get; set; }

		[JsonProperty("sendAttempts")]
		public int? SendAttempts { get; set; }

		[JsonProperty("openCount")]
		public int? OpenCount { get; set; }

		[JsonProperty("lastSent")]
		public DateTime? LastSent { get; set; }

		[JsonProperty("candidateName")]
		public string CandidateName { get; set; }

		[JsonProperty("candidateEmail")]
		public string CandidateEmail { get; set; }

		[JsonProperty("testTeamMember")]
		public bool? TestTeamMember { get; set; }

		[JsonProperty("inviterRole")]
		public string InviterRole { get; set; }

		[JsonProperty("invitePath")]
		public string InvitePath { get; set; }

		[JsonProperty("invitePracticePath")]
		public string InvitePracticePath { get; set; }
	}
}