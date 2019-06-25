using Newtonsoft.Json;
using Qualified.Data;
using Qualified.Exceptions;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Qualified
{
	public class Client
	{
		private readonly string key;
		private readonly HttpClient client;

		private const string ApiURL = "https://www.qualified.io/api/v1/";

		public Client(string key)
		{
			this.key = key;
			client = new HttpClient
			{
				BaseAddress = new Uri(ApiURL)
			};
			client.DefaultRequestHeaders.Add("Authorization", this.key);
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}

		public async Task<Page<Assessment>> GetAssessmentsAsync() =>
			Deserialize<Page<Assessment>>(await GetAsync("assessments"));

		public async Task<AssessmentResult> GetAssessmentResults(string assessmentId, string assessmentResultsId)
		{
			var result = Deserialize<Page<AssessmentResult>>(await GetAsync($"assessment_results?assessment_id={assessmentId}"));
			return result.Data.SingleOrDefault(item => item.Id == assessmentResultsId);
		}

		public async Task<Page<AssessmentSent>> SendAssessmentAsync(string assessmentId, string[] candidates)
		{
			var body = JsonConvert.SerializeObject(new DataOnly<SendAssessment>
			{
				Data = new SendAssessment
				{
					Candidates = candidates,
					AssessmentId = assessmentId
				}
			});
			var requestBody = new StringContent(body, Encoding.UTF8, "application/json");
			return Deserialize<Page<AssessmentSent>>(await PostAsync($"assessment_invitations/invite_candidates", requestBody));
		}

		private async Task<string> GetAsync(string uri) =>
			await GetContentAsync(await client.GetAsync(uri));

		private async Task<string> PostAsync(string uri, StringContent requestBody = null) =>
			await GetContentAsync(await client.PostAsync(uri, requestBody ?? new StringContent(String.Empty, Encoding.UTF8, "application/json")));

		private static async Task<string> GetContentAsync(HttpResponseMessage response)
		{
			var content = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				return content;
			}
			else if (response.StatusCode == HttpStatusCode.BadRequest)
			{
				throw new QualifiedException(Deserialize<Error>(content), "400");
			}
			else if (response.StatusCode == HttpStatusCode.Forbidden)
			{
				throw new QualifiedException("The API Key is invalid");
			}
			else
			{
				throw new QualifiedException(Deserialize<Error>(content), response.StatusCode.ToString());
			}
		}

		private static T Deserialize<T>(string message)
		{
			var output = JsonConvert.DeserializeObject<T>(message);
			if ((object)output == null)
			{
				throw new QualifiedException("An error occurred while deserializing the response body");
			}
			return output;
		}
	}
}