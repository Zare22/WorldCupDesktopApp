using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Constants
{
    public static partial class APIConstants
    {
        
        //Men
        public const string TEAMS = "http://world-cup-json-2018.herokuapp.com/teams/results";
        //public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";

        //Women
        //public const string WOMEN_TEAMS = "http://worldcup.sfg.io/teams/results";
        ////public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        //public const string WOMEN_MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";
    }

    public static partial class APIConstantsWomen
    {
        public const string TEAMS = "http://worldcup.sfg.io/teams/results";
        //public const string MATCHES = "http://world-cup-json-2018.herokuapp.com/matches";
        public const string MATCHES = "http://worldcup.sfg.io/matches/country?fifa_code=";
    }
}
