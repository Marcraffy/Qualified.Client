using Newtonsoft.Json;

namespace Qualified
{
	public class Percentiles
	{
		[JsonProperty("10.0")]
		public int? Tenth { get; set; }

		[JsonProperty("25.0")]
		public int? TwentyFifth { get; set; }

		[JsonProperty("50.0")]
		public int? Fiftieth { get; set; }

		[JsonProperty("60.0")]
		public int? Sixtieth { get; set; }

		[JsonProperty("70.0")]
		public int? Seventieth { get; set; }

		[JsonProperty("75.0")]
		public int? SeventyFifth { get; set; }

		[JsonProperty("80.0")]
		public int? Eighteith { get; set; }

		[JsonProperty("85.0")]
		public int? EightyFifth { get; set; }

		[JsonProperty("90.0")]
		public int? Ninetieth { get; set; }

		[JsonProperty("95.0")]
		public int? NinetyFifth { get; set; }

		[JsonProperty("99.0")]
		public int? NinetyNinth { get; set; }
	}
}