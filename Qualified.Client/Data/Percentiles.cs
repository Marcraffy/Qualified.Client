using Newtonsoft.Json;

namespace Qualified
{
	public class Percentiles
	{
		[JsonProperty("10.0")]
		public double? Tenth { get; set; }

		[JsonProperty("25.0")]
		public double? TwentyFifth { get; set; }

		[JsonProperty("50.0")]
		public double? Fiftieth { get; set; }

		[JsonProperty("60.0")]
		public double? Sixtieth { get; set; }

		[JsonProperty("70.0")]
		public double? Seventieth { get; set; }

		[JsonProperty("75.0")]
		public double? SeventyFifth { get; set; }

		[JsonProperty("80.0")]
		public double? Eighteith { get; set; }

		[JsonProperty("85.0")]
		public double? EightyFifth { get; set; }

		[JsonProperty("90.0")]
		public double? Ninetieth { get; set; }

		[JsonProperty("95.0")]
		public double? NinetyFifth { get; set; }

		[JsonProperty("99.0")]
		public double? NinetyNdoubleh { get; set; }
	}
}