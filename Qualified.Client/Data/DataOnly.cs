using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qualified.Data
{
	internal class DataOnly<T> where T: class
	{
		[JsonProperty("data")]
		public T Data { get; set; }
	}
}
