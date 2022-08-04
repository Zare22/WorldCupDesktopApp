using DataLayer.Enums;
using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
    public class Manager
    {
        private readonly SettingsManager settingsManager = new SettingsManager();
        private readonly IRepository repository;
        private bool testConnection => Connection();

        private bool Connection()
        {
            try
            {
                bool test = new Ping().Send("www.google.com").Status == IPStatus.Success;
                return test;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string Championship => settingsManager.CheckForChampionshipType() ? "Men" : "Women";

        public Manager() => repository = RepositoryFactory.GetRepository(testConnection);

        public Task<IList<TeamFromResults>> GetAllTeams() => repository.GetAllTeams(Championship);
        public Task<ISet<Player>> GetPlayers(string fifaCode) => repository.GetPlayers(fifaCode, Championship);
        public Task<IList<Match>> GetAllMatches(string fifaCode) => repository.GetMatchesByCode(fifaCode, Championship);
    }
}
