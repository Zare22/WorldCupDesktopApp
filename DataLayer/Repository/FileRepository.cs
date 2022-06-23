using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using DataLayer.Constants;

namespace DataLayer.Repository
{
    internal class FileRepository : IRepository
    {
        public Task<IList<TeamFromResults>> GetAllTeams(string championship)
        {
            //var path = championship == "Men" ? PathConstants.JSON_FOLDER 
            return Task.Run(async () =>
            {
                var stringJson = File.ReadAllText($"{PathConstants.JSON_FOLDER}Women\\results.json");
                return TeamFromResults.FromJson(stringJson);
            });
        }

        public Task<IList<Match>> GetMatchesByCode(string fifaCode, string championship)
        {
            return Task.Run(async () =>
            {
                var stringJson = File.ReadAllText($"{PathConstants.JSON_FOLDER}Women\\FifaCode\\{fifaCode}.json");
                return Match.FromJson(stringJson);
            });
        }

        public Task<ISet<Player>> GetPlayers(string fifaCode, string championship)
        {
            return Task.Run(async () =>
            {
                var stringJson = File.ReadAllText($"{PathConstants.JSON_FOLDER}Women\\FifaCode\\{fifaCode}.json");
                var matches = Match.FromJson(stringJson);
                return Player.GetPlayers(matches[0], matches, fifaCode);
            });
        }
    }
}
