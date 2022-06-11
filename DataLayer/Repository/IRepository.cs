using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IRepository
    {
        Task<IList<TeamFromResults>> GetAllTeams();
        Task<IList<Match>> GetAllMatches();
        Task<IList<Match>> GetMatchesByCode(string fifaCode);
    }
}
