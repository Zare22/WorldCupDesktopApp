using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer.Managers;
using WorldCupWindowsForms.UserControls;
using System.IO;
using System.Globalization;
using System.Threading;
using WorldCupWindowsForms.Protocols;
using System.Reflection;
using DataLayer.Constants;
using System.Resources;
using System.Collections;

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form, IPlayerMovable
    {
        private SettingsForm settingsForm = new SettingsForm();
        private readonly Manager manager = new Manager();

        private PlayerUC playerControl;

        private ISet<Player> players;
        private IList<Match> matches;

        public string SelectedTeam { get; set; }

        public IDictionary<string, bool> FavPlayers { get; set; } = new Dictionary<string, bool>();



        public MainForm()
        {
            FillFavoritePlayers();
            InitializeComponent();
        }

        //Main form logic
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(PathConstants.Settings_WinFormApp))
            {
                ShowSettingsForm();
            }
            else
            {
                SetCulture(settingsForm.Language);
                FillDdl();
            }
        }

        private async void FillDdl()
        {
            SetChampionship(settingsForm.Championship);
            try
            {
                var teams = await manager.GetAllTeams();
                teams.ToList().ForEach(t => ddlTeams.Items.Add(t));


            }
            catch (Exception)
            {
                ShowMessage("Došlo je do pogreške kod učitavanja timova");
                return;
            }

            if (File.Exists($"{PathConstants.FavoriteTeam_WinFormApp}{settingsForm.Championship}FavoriteTeam.resx"))
            {
                string team;
                using (ResXResourceSet reader = new ResXResourceSet($"{PathConstants.FavoriteTeam_WinFormApp}{settingsForm.Championship}FavoriteTeam.resx"))
                {
                    team = reader.GetString("Team");
                }
                ddlTeams.SelectedIndex = ddlTeams.FindStringExact(team);
            }
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPlayers.Controls.Clear();
            pnlFavoritePlayers.Controls.Clear();
            SetSelectedTeam();

            FillPanelWithPlayers();
        }

        private async void FillPanelWithPlayers()
        {
            try
            {
                players = await manager.GetPlayers(SelectedTeam);
                foreach (var p in players)
                {
                    playerControl = new PlayerUC(p, this);
                    if (playerControl.PlayerInUC.Favorite)
                    {
                        pnlFavoritePlayers.Controls.Add(playerControl);
                    }
                    else
                    {
                        pnlPlayers.Controls.Add(playerControl);
                    }
                }
            }
            catch (Exception)
            {
                ShowMessage("Došlo je do pogreške kod učitavanja igrača");
                return;
            }
        }

        //Drag and drop
        private void Panels_DragEnter(object sender, DragEventArgs e)
        {
            var startingPanel = playerControl.Parent;
            var dropPanel = (FlowLayoutPanel)sender;

            if (startingPanel != dropPanel)
            {
                e.Effect = DragDropEffects.Move;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void pnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            var dropPanel = (FlowLayoutPanel)sender;

            if (dropPanel == pnlPlayers)
            {
                pnlPlayers.Controls.Add(playerControl);
            }
            else if (dropPanel == pnlFavoritePlayers)
            {
                pnlFavoritePlayers.Controls.Add(playerControl);
            }

            playerControl.CheckFavorite();
        }

        //Players and PlayerUC logic
        public void MovePlayerControl(PlayerUC playerUC)
        {
            if (playerUC.Parent == pnlPlayers)
            {
                if (pnlFavoritePlayers.Controls.Count >= 3)
                {
                    ShowMessage("Maksimalno možete odabrati 3 favorita!");
                    return;
                }
                pnlFavoritePlayers.Controls.Add(playerUC);
                FavPlayers.Add(playerUC.Name, playerUC.PlayerInUC.Favorite);
            }
            else
            {
                pnlPlayers.Controls.Add(playerUC);
                FavPlayers.Remove(playerUC.Name);
            }

            SaveFavorites();
            playerUC.CheckFavorite();
        }


        private void SaveFavorites()
        {
            IEnumerator<KeyValuePair<string, bool>> enumerator = FavPlayers.GetEnumerator();
            using (ResXResourceWriter writer = new ResXResourceWriter(PathConstants.FavoritePlayers_WinFormApp))
            {
                while (enumerator.MoveNext())
                    writer.AddResource(enumerator.Current.Key, enumerator.Current.Value);
            }
        }


        //Settings logic
        private void btnSettings_Click(object sender, EventArgs e) => ShowSettingsForm();

        private void ShowSettingsForm()
        {
            var result = settingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                SetCulture(settingsForm.Language);
                FillDdl();
            }
        }

        private void SetCulture(string language)
        {
            CultureInfo culture = new CultureInfo(language);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            this.Controls.Clear();
            InitializeComponent();
        }


        //Statistics form call
        private async void btnOpenStatisticsForm_Click(object sender, EventArgs e)
        {
            try
            {
                matches = await manager.GetAllMatches(SelectedTeam);
            }
            catch (Exception)
            {
                ShowMessage("Niste odabrali reprezentaciju");
                return;
            }

            StatisticsForm statisticsForm = new StatisticsForm(matches, players);
            statisticsForm.ShowDialog();
        }


        //Exception message
        private static void ShowMessage(string message)
        {
            MessageBox.Show(message);
            return;
        }


        //Properties setting
        private void FillFavoritePlayers()
        {
            if (File.Exists(PathConstants.FavoritePlayers_WinFormApp))
            {
                using (ResourceSet reader = new ResXResourceSet(PathConstants.FavoritePlayers_WinFormApp))
                {
                    IDictionaryEnumerator dict = reader.GetEnumerator();
                    while (dict.MoveNext())
                    {
                        FavPlayers.Add(dict.Key.ToString(), (bool)dict.Value);
                    }
                }
            }
        }

        private void SetSelectedTeam()
        {
            string team = ddlTeams.SelectedItem.ToString();
            string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

            SelectedTeam = fifaCode;
        }

        private void SetChampionship(string championshipType) => manager.Championship = championshipType;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ddlTeams.SelectedIndex == -1)
            {
                Application.Exit();
            }
            else SaveSelectedTeam();
        }

        private void SaveSelectedTeam()
        {
            string sex = settingsForm.Championship;
            using (ResXResourceWriter writer = new ResXResourceWriter($"{PathConstants.FavoriteTeam_WinFormApp}{sex}FavoriteTeam.resx"))
            {
                writer.AddResource("Team", ddlTeams.SelectedItem.ToString());
            }
        }
    }
}