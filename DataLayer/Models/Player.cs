﻿using DataLayer.JsonHandling;
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

        public bool Favorite { get; set; } = false;

        public TeamFromMatch PlayersTeam { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("captain", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsCaptain { get; set; }

        [JsonProperty("shirt_number", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShirtNumber { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public Position? Position { get; set; }


        public int CompareTo(Player other) => Name.CompareTo(other.Name);

        public override bool Equals(object obj) => obj is Player player && Name == player.Name;

        public override int GetHashCode() => 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);


        //Methods
        internal static ISet<Player> GetPlayers(Match match, IList<Match> matches, string fifaCode)
        {
            var players = new HashSet<Player>();
            if (match.HomeTeam.Code == fifaCode)
            {
                players = players.
                    Concat(match.HomeTeamStatistics.StartingEleven).
                    Concat(match.HomeTeamStatistics.Substitutes).ToHashSet();
                players.ToList().ForEach(p => p.PlayersTeam = match.HomeTeam);
            }
            else
            {
                players = players.
                    Concat(match.AwayTeamStatistics.StartingEleven).
                    Concat(match.AwayTeamStatistics.Substitutes).ToHashSet();
                players.ToList().ForEach(p => p.PlayersTeam = match.AwayTeam);
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
