using DataLayer.Models;
using DataLayer.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace DataLayer.Repository
{
    class APIRepository : IRepository
    {
        public Task<IList<TeamFromResults>> GetAllTeams(string championship)
        {
            var path = championship == "Men" ? APIConstants.TEAMS : APIConstantsWomen.TEAMS;
            return Task.Run(async () =>
            {
                var apiClient = new RestClient(path);
                var apiResult = await apiClient.ExecuteAsync<IList<TeamFromResults>>(new RestRequest());
                return JsonConvert.DeserializeObject<IList<TeamFromResults>>(apiResult.Content);
            });
        }

        public Task<IList<Match>> GetMatchesByCode(string fifaCode, string championship)
        {
            var path = championship == "Men" ? APIConstants.MATCHES : APIConstantsWomen.MATCHES;
            return Task.Run(async () =>
                {
                    var apiClient = new RestClient($"{path}{fifaCode}");
                    var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                    return Match.FromJson(apiResult.Content);
                });
        }

        public Task<ISet<Player>> GetPlayers(string fifaCode, string championship)
        {
            var path = championship == "Men" ? APIConstants.MATCHES : APIConstantsWomen.MATCHES;
            return Task.Run(async () =>
            {
                var apiClient = new RestClient($"{path}{fifaCode}");
                var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                var matches = Match.FromJson(apiResult.Content);
                return Player.GetPlayers(matches[0], matches, fifaCode);
            });
        }
    }
}
