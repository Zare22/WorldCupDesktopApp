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

        public Task<IList<TeamFromResults>> GetAllTeams() => repository.GetAllTeams();
        
    }
}
