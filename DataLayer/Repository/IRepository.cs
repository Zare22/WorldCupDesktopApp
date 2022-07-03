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
        Task<IList<TeamFromResults>> GetAllTeams(string championship);
        Task<IList<Match>> GetMatchesByCode(string fifaCode, string championship);
        Task<ISet<Player>> GetPlayers(string fifaCode, string championship);
    }
}
