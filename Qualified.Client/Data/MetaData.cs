using Newtonsoft.Json;
using System;

namespace Qualified.Data
{
	public class MetaData
	{
		[JsonProperty("timestamp")]
		public DateTime TimeStamp { get; set; }

		[JsonProperty("includes")]
		public string[] Includes { get; set; }
	}
}