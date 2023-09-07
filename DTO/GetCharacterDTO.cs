using System;
using Rest_Demo.Models;

namespace Rest_Demo.DTO
{
    public class GetCharacterDTO
    {
        public string Name { get; set; } = "Froodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    
	}
}

