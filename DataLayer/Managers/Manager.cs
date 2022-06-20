﻿using DataLayer.Enums;
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
        private readonly IRepository repository;
        private bool testConnection = new Ping().Send("www.google.com").Status == IPStatus.Success;

        public string Championship { get; set; }

        public Manager() => repository = RepositoryFactory.GetRepository(testConnection);

        public Task<IList<TeamFromResults>> GetAllTeams() => repository.GetAllTeams(Championship);
        public Task<ISet<Player>> GetPlayers(string fifaCode) => repository.GetPlayers(fifaCode, Championship);
        public Task<IList<Match>> GetAllMatches(string fifaCode) => repository.GetMatchesByCode(fifaCode, Championship);
    }
}
