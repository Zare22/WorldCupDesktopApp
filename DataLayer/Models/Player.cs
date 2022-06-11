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

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   GoalsScored == player.GoalsScored &&
                   YellowCards == player.YellowCards &&
                   ImagePath == player.ImagePath &&
                   Name == player.Name &&
                   IsCaptain == player.IsCaptain &&
                   ShirtNumber == player.ShirtNumber &&
                   Position == player.Position;
        }

        public override int GetHashCode()
        {
            int hashCode = -1581627149;
            hashCode = hashCode * -1521134295 + GoalsScored.GetHashCode();
            hashCode = hashCode * -1521134295 + YellowCards.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImagePath);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + IsCaptain.GetHashCode();
            hashCode = hashCode * -1521134295 + ShirtNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + Position.GetHashCode();
            return hashCode;
        }
    }
}
