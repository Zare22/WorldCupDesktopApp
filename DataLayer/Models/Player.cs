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
        public int GoalsScored { get; private set; }
        public int YellowCards { get; private set; }
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


        public int CompareTo(Player other) => Name.CompareTo(other.Name);

        public override bool Equals(object obj) => obj is Player player && Name == player.Name;

        public override int GetHashCode() => 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);


        //Methods
        internal static ISet<Player> GetPlayers(IList<Match> matches, string fifaCode)
        {
            var players = new HashSet<Player>();
            foreach (var m in matches)
            {
                if (m.HomeTeam.Code == fifaCode)
                {
                    players = players.
                        Concat(m.HomeTeamStatistics.StartingEleven).
                        Concat(m.HomeTeamStatistics.Substitutes).ToHashSet();
                }
                else
                {
                    players = players.
                        Concat(m.AwayTeamStatistics.StartingEleven).
                        Concat(m.AwayTeamStatistics.Substitutes).ToHashSet();
                }
            }
            players.ToList().ForEach(p => p.GoalsAndYellows(p, matches, fifaCode));
            return players;
        }

        private void GoalsAndYellows(Player player, IList<Match> matches, string fifaCode)
        {
            foreach (var m in matches)
            {
                if (m.HomeTeam.Code == fifaCode)
                {
                    foreach (var matchEvent in m.HomeTeamEvents)
                    {
                        if (IsGoal(player, matchEvent))
                        {
                            ++GoalsScored;
                        }
                        if (IsYellow(player, matchEvent))
                        {
                            ++YellowCards;
                        }
                    }
                }
                else
                {
                    foreach (var matchEvent in m.AwayTeamEvents)
                    {
                        if (IsGoal(player, matchEvent))
                        {
                            ++GoalsScored;
                        }
                        if (IsYellow(player, matchEvent))
                        {
                            ++YellowCards;
                        }
                    }
                }
            }
        }

        private bool IsYellow(Player player, TeamEvent matchEvent) => player.Name.ToLower() == matchEvent.Player.ToLower() && matchEvent.TypeOfEvent == TypeOfEvent.YellowCard;
        private bool IsGoal(Player player, TeamEvent matchEvent) => player.Name.ToLower() == matchEvent.Player.ToLower() && matchEvent.TypeOfEvent == TypeOfEvent.Goal;
        //Changed DataLayer.JsonHandling.TypeOfEventConverter to count penalties as goals and 2nd yellows as yellows
    }
}
