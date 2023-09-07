using System;
using System.Text.Json.Serialization;

namespace Rest_Demo.Models
{
	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum RpgClass
	{
		Knight = 1,
		Mage = 2,
		Club = 3
	}
}

