using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Constants
{
    public static partial class APIConstantsMen
    {
        public const string TEAMS_RESULTS = "http://world-cup-json-2018.herokuapp.com/teams/results";
        //public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
    }

    public static partial class APIConstantsWomen
    {
        public const string TEAMS_RESULTS = "http://worldcup.sfg.io/teams/results";
        //public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        public const string MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";
    }
}
