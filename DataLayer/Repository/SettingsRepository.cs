using DataLayer.Constants;
using System;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using DataLayer.Models;

namespace DataLayer.Repository
{
    internal class SettingsRepository : ISettings
    {
        public bool CheckForChampionshipType()
        {
            bool checker = false;
            if (File.Exists($"{PathConstants.Settings}"))
            {
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.Settings}"))
                {
                    if (reader.GetString("Championship type") == "Men")
                    {
                        checker = true;
                    }
                }
            }
            return checker;
        }

        public bool CheckForLanguage()
        {
            bool checker = false;
            if (File.Exists($"{PathConstants.Settings}"))
            {
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.Settings}"))
                {
                    if (reader.GetString("Language") == "hr")
                    {
                        checker = true;
                    }
                }
            }
            return checker;
        }

        public void SaveSettingsToResources(string championship, string language)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter($"{PathConstants.Settings}"))
            {
                writer.AddResource("Championship type", championship);
                writer.AddResource("Language", language);
            }
        }

        public string SetFavoriteTeam(string championship)
        {
            string team;
            if (File.Exists($"{PathConstants.FavoriteTeam}{championship}FavoriteTeam.resx"))
            {
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.FavoriteTeam}{championship}FavoriteTeam.resx"))
                {
                    team = reader.GetString("Team");
                }
                return team;
            }
            else
                return string.Empty;
        }

        public void SaveFavoritePlayers(IDictionary<string, bool> favoritePlayers)
        {
            IEnumerator<KeyValuePair<string, bool>> enumerator = favoritePlayers.GetEnumerator();
            using (ResXResourceWriter writer = new ResXResourceWriter(PathConstants.FavoritePlayers_WinFormApp))
            {
                while (enumerator.MoveNext())
                    writer.AddResource(enumerator.Current.Key, enumerator.Current.Value);
            }
        }

        public IDictionary<string, bool> FillFavoritePlayers(IDictionary<string, bool> favoritePlayers)
        {
            if (File.Exists(PathConstants.FavoritePlayers_WinFormApp))
            {
                using (ResourceSet reader = new ResXResourceSet(PathConstants.FavoritePlayers_WinFormApp))
                {
                    IDictionaryEnumerator dict = reader.GetEnumerator();
                    while (dict.MoveNext())
                    {
                        favoritePlayers.Add(dict.Key.ToString(), (bool)dict.Value);
                    }
                }
                return favoritePlayers;
            }
            else
                return favoritePlayers;
        }

        public void SaveFavoriteTeam(string sex, string team)
        {
            using (ResXResourceWriter writer = new ResXResourceWriter($"{PathConstants.FavoriteTeam}{sex}FavoriteTeam.resx"))
            {
                writer.AddResource("Team", team);
            }
        }

        public void CheckFavoritePlayer(Player player)
        {
            if (File.Exists(PathConstants.FavoritePlayers_WinFormApp))
            {
                using (ResourceSet reader = new ResXResourceSet(PathConstants.FavoritePlayers_WinFormApp))
                {
                    IDictionaryEnumerator dict = reader.GetEnumerator();
                    while (dict.MoveNext())
                        if (dict.Key.ToString() == player.Name)
                        {
                            player.Favorite = (bool)dict.Value;
                        }
                }
            }
        }
    }
}
