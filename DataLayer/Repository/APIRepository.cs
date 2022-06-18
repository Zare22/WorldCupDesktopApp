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
        public Task<IList<Match>> GetAllMatches()
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient(APIConstantsMen.MATCHES);
                var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                return Match.FromJson(apiResult.Content);
            });
        }

        public Task<IList<TeamFromResults>> GetAllTeams()
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient(APIConstantsMen.TEAMS_RESULTS);
                var apiResult = await apiClient.ExecuteAsync<IList<TeamFromResults>>(new RestRequest());
                return JsonConvert.DeserializeObject<IList<TeamFromResults>>(apiResult.Content);
            });
        }

        public Task<IList<Match>> GetMatchesByCode(string fifaCode)
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient($"{APIConstantsMen.COUNTRY_BY_CODE}{fifaCode}");
                var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                return Match.FromJson(apiResult.Content);
            });
        }

        public Task<ISet<Player>> GetPlayers(/*[Optional]*/ string fifaCode)
        {
            return Task.Run(async () =>
            {
                var apiClient = new RestClient($"{APIConstantsMen.COUNTRY_BY_CODE}{fifaCode}");
                var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                var matches = Match.FromJson(apiResult.Content);
                return Player.GetPlayers(matches[0], matches,  fifaCode);
            });
        }

        //private static ISet<Player> GetCountryPlayers(IList<Match> matches, /*[Optional]*/ string fifaCode)
        //{
        //    var players = new HashSet<Player>();
        //    foreach (var m in matches)
        //    {
        //        if (m.HomeTeam.Code == fifaCode)
        //        {
        //            players = players.
        //                Concat(m.HomeTeamStatistics.StartingEleven).
        //                Concat(m.HomeTeamStatistics.Substitutes).ToHashSet();
        //        }
        //        else
        //        {
        //            players = players.
        //                Concat(m.AwayTeamStatistics.StartingEleven).
        //                Concat(m.AwayTeamStatistics.Substitutes).ToHashSet();
        //        }
        //    }
        //    return players;
        //}
    }
}
