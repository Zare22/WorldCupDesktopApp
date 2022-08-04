using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
    public class SettingsManager
    {
        private readonly ISettings resrepo;

        public SettingsManager() => resrepo = RepositoryFactory.GetResourcesRepository();

        public bool CheckForChampionshipType() => resrepo.CheckForChampionshipType();
        public bool CheckForLanguage() => resrepo.CheckForLanguage();
        public void SaveSettingsToResources(string championship, string language) => resrepo.SaveSettingsToResources(championship, language);
        public string SetFavoriteTeam(string championship) => resrepo.SetFavoriteTeam(championship);
        public void SaveFavoritePlayers(IDictionary<string, bool> favoritePlayers) => resrepo.SaveFavoritePlayers(favoritePlayers);
        public IDictionary<string, bool> FillFavoritePlayers(IDictionary<string, bool> favoritePlayers) => resrepo.FillFavoritePlayers(favoritePlayers);
        public void SaveFavoriteTeam(string sex, string team) => resrepo.SaveFavoriteTeam(sex, team);
        public void CheckFavoritePlayer(Player player) => resrepo.CheckFavoritePlayer(player);
    } 
}
