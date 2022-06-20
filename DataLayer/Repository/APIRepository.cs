﻿using DataLayer.Models;
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
        //public Task<IList<Match>> GetAllMatches()
        //{
        //    return Task.Run(async () =>
        //    {
        //        var apiClient = new RestClient(APIConstantsMen.MATCHES);
        //        var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
        //        return Match.FromJson(apiResult.Content);
        //    });
        //}

        public Task<IList<TeamFromResults>> GetAllTeams(string championship)
        {
            if (championship == "Men")
            {
                return Task.Run(async () =>
                {
                    var apiClient = new RestClient(APIConstants.MEN_TEAMS);
                    var apiResult = await apiClient.ExecuteAsync<IList<TeamFromResults>>(new RestRequest());
                    return JsonConvert.DeserializeObject<IList<TeamFromResults>>(apiResult.Content);
                });
            }
            else
            {
                return Task.Run(async () =>
                {
                    var apiClient = new RestClient(APIConstants.WOMEN_TEAMS);
                    var apiResult = await apiClient.ExecuteAsync<IList<TeamFromResults>>(new RestRequest());
                    return JsonConvert.DeserializeObject<IList<TeamFromResults>>(apiResult.Content);
                });
            }
        }

        public Task<IList<Match>> GetMatchesByCode(string fifaCode, string championship)
        {
            if (championship == "Men")
            {
                return Task.Run(async () =>
                    {
                        var apiClient = new RestClient($"{APIConstants.MEN_MATCHES}{fifaCode}");
                        var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                        return Match.FromJson(apiResult.Content);
                    });
            }
            else
            {
                return Task.Run(async () =>
                {
                    var apiClient = new RestClient($"{APIConstants.WOMEN_MATCHES}{fifaCode}");
                    var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                    return Match.FromJson(apiResult.Content);
                });
            }
        }

        public Task<ISet<Player>> GetPlayers(/*[Optional]*/ string fifaCode, string championship)
        {
            if (championship == "Men")
            {
                return Task.Run(async () =>
                {
                    var apiClient = new RestClient($"{APIConstants.MEN_MATCHES}{fifaCode}");
                    var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                    var matches = Match.FromJson(apiResult.Content);
                    return Player.GetPlayers(matches[0], matches, fifaCode);
                });
            }
            else
            {
                return Task.Run(async () =>
                {
                    var apiClient = new RestClient($"{APIConstants.WOMEN_MATCHES}{fifaCode}");
                    var apiResult = await apiClient.ExecuteAsync<IList<Match>>(new RestRequest());
                    var matches = Match.FromJson(apiResult.Content);
                    return Player.GetPlayers(matches[0], matches, fifaCode);
                });
            }
        }
    }
}
