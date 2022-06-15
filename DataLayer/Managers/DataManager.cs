//using DataLayer.Models;
//using DataLayer.Repository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataLayer.Managers
//{
//    //PITATI PROFESORA
//    public class DataManager
//    {
//        private readonly IRepository repository;
//        public DataManager() => repository = RepositoryFactory.GetRepository();

//        public string Team { get; set; }


//        public IList<Match> Matches => repository.GetAllMatches().Result;

//        public IList<TeamFromResults> TeamsFromResults => repository.GetAllTeams().Result;

//        public IList<Player> Players => LoadPlayers(Matches, Team);


//        private IList<Player> LoadPlayers(IList<Match> matches, string team)
//        {
//            var players = new List<Player>();
//            foreach (var m in matches)
//            {
//                if (m.HomeTeam.Country == team)
//                {
//                    foreach (var p in m.HomeTeamStatistics.StartingEleven.Concat(m.HomeTeamStatistics.Substitutes))
//                    {
//                        players.Add(p);
//                    }
//                }
//            }
//            return players.Distinct().ToList();
//        }

//    }
//}
