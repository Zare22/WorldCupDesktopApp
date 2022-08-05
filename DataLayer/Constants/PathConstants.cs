using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Constants
{
    public static class PathConstants
    {
        
        private static readonly string PROJECT_DIRECTORY = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        

        private const string FORMS_RESOURCES = "\\WorldCupWindowsForms\\Resources\\";
        private const string WPF_RESOURCES = "\\WorldCupWPF\\Resources\\";

        private const string DATALAYER_RESOURCES = "\\DataLayer\\DataLayerResources\\";

        private const string WOMEN_TEAMS = "JsonFiles\\Women\\results.json";
        private const string WOMEN_MATCHES = "JsonFiles\\Women\\FifaCode\\";

        private const string MEN_MATCHES = "JsonFiles\\Men\\FifaCode\\";
        private const string MEN_TEAMS = "JsonFiles\\Men\\results.json";


        private static readonly string FullWomenTeams = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}{WOMEN_TEAMS}";
        private static readonly string FullMenTeams = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}{MEN_TEAMS}";

        public static string GetTeamsChampionshipType(string championshipType) => championshipType == "Men" ? FullMenTeams : FullWomenTeams;

        private static readonly string FullWomenMatches = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}{WOMEN_MATCHES}";
        private static readonly string FullMenMatches = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}{MEN_MATCHES}";

        public static string GetMatchesChampionshipType(string championshipType) => championshipType == "Men" ? FullMenMatches : FullWomenMatches;

        public static string Player_Images = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}PlayerImages\\";

        public static string Settings = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}Settings.resx";
        public static string Resolution = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}Resolution.resx";
        public static string FavoritePlayers_WinFormApp = $"{PROJECT_DIRECTORY}{FORMS_RESOURCES}FavoritePlayers.resx";
        public static string FavoriteTeam = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}";
        public static string FootbalPlayerImage = $"{PROJECT_DIRECTORY}{DATALAYER_RESOURCES}FootballPlayer.png";

    }
}
