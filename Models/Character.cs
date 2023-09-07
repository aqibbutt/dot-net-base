using System;
using System.ComponentModel.DataAnnotations;

namespace Rest_Demo.Models
{
	public class Character
	{
        [Key]
		public int Id { get; set; }
		public string Name { get; set; } = "Froodo";
		public int HitPoints { get; set; } = 100;
		public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
     
	}
}

