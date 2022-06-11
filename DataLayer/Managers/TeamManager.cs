using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
    public class TeamManager
    {
        private readonly IRepository repository;
        public TeamManager() => repository = RepositoryFactory.GetRepository();

        private IList<Match> Matches
        {
            get => repository.GetAllMatches().Result;
        }

        public IList<TeamFromResults> TeamsFromResults
        {
            get => repository.GetAllTeams().Result;
        }

        public IList<Player> Players
        {
            get => LoadPlayers(Matches);
        }

        private IList<Player> LoadPlayers(IList<Match> matches)
        {
            var players = new List<Player>();
            foreach (var m in matches)
            {
                foreach (var p in m.HomeTeamStatistics.StartingEleven.Concat(m.HomeTeamStatistics.Substitutes))
                {
                    players.Add(p);
                }
            }
            return players.Distinct().ToList();
        }

    }
}
