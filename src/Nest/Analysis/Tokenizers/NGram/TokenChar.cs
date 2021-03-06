using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nest
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TokenChar
	{
		[EnumMember(Value = "letter")]
		Letter,
		[EnumMember(Value = "digit")]
		Digit,
		[EnumMember(Value = "whitespace")]
		Whitespace,
		[EnumMember(Value = "punctuation")]
		Punctuation,
		[EnumMember(Value = "symbol")]
		Symbol,
	}
}