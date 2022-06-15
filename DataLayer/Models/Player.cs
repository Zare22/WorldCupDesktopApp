using DataLayer.JsonHandling;
using DataLayer.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
	public class Player : IComparable<Player>
	{
        public int GoalsScored { get; set; }
        public int YellowCards { get; set; }
        public string ImagePath { get; set; }

        [JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("captain")]
		public bool IsCaptain { get; set; }

		[JsonProperty("shirt_number")]
		public int ShirtNumber { get; set; }

		[JsonProperty("position")]
		[JsonConverter(typeof(PositionConverter))]
		public Position Position { get; set; }
        public int CompareTo(Player other) => GoalsScored.CompareTo(other.GoalsScored);

        public override bool Equals(object obj) => obj is Player player && Name == player.Name;

        public override int GetHashCode() => 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
    }
}
