using DataLayer.Enums;
using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
    public class Manager
    {
        private readonly IRepository repository;
        public Manager() => repository = RepositoryFactory.GetFileRepository();
        //public Manager() => repository = RepositoryFactory.GetAPIRepository();

        public Task<IList<TeamFromResults>> GetAllTeams() => repository.GetAllTeams();
        public Task<ISet<Player>> GetPlayers(string fifaCode) => repository.GetPlayers(fifaCode);
        public Task<IList<Match>> GetAllMatches(string fifaCode) => repository.GetMatchesByCode(fifaCode);
    }
}
