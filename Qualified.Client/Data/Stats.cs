using Newtonsoft.Json;
using System;

namespace Qualified
{
	public class Stats
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("avg")]
		public double? Average { get; set; }

		[JsonProperty("buckets")]
		public object Buckets { get; set; }

		[JsonProperty("count")]
		public int? Count { get; set; }

		[JsonProperty("distinct")]
		public int? Distinct { get; set; }

		[JsonProperty("field")]
		public string Field { get; set; }

		[JsonProperty("histogram")]
		public object Histogram { get; set; }

		[JsonProperty("interval")]
		public int? Interval { get; set; }

		[JsonProperty("inverted")]
		public bool? Inverted { get; set; }

		[JsonProperty("max")]
		public double? Max { get; set; }

		[JsonProperty("min")]
		public double? Min { get; set; }

		[JsonProperty("percentiles")]
		public Percentiles Percentiles { get; set; }

		[JsonProperty("stdDeviation")]
		public double? StandardDeviation { get; set; }

		[JsonProperty("stdDeviationBounds")]
		public StandardDeviationBounds StandardDeviationBounds { get; set; }

		[JsonProperty("sum")]
		public double? Sum { get; set; }

		[JsonProperty("variance")]
		public double? Variance { get; set; }
	}
}