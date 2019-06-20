using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qualified.Data
{
	public class Page<T> where T : class
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("data")]
		public T Data { get; set; }

		[JsonProperty("currentPage")]
		public int? CurrentPage { get; set; }

		[JsonProperty("totalPages")]
		public int? TotalPages { get; set; }

		[JsonProperty("totalCount")]
		public int? TotalCount { get; set; }

		[JsonProperty("meta")]
		public MetaData Meta { get; set; }
	}
}
