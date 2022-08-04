using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface ISettings
    {
        void SaveSettingsToResources(string championship, string language);
        bool CheckForLanguage();
        bool CheckForChampionshipType();

        string SetFavoriteTeam(string championship);
        void SaveFavoritePlayers(IDictionary<string, bool> favoritePlayers);
        IDictionary<string, bool> FillFavoritePlayers(IDictionary<string, bool> favoritePlayers);
        void SaveFavoriteTeam(string sex, string team);
        void CheckFavoritePlayer(Player player);
    }
}
