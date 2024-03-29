﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer.Managers;
using WorldCupWindowsForms.UserControls;
using System.IO;
using System.Globalization;
using System.Threading;
using WorldCupWindowsForms.Protocols;
using DataLayer.Constants;
using DataLayer.Exceptions;
using System.Threading.Tasks;

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form, IPlayerMovable
    {

        private readonly SettingsManager settingsManager = new SettingsManager();
        private readonly Manager manager = new Manager();

        private PlayerUC playerControl;

        private ISet<Player> players;
        private IList<Match> matches;

        private string SelectedTeam;
        private string Championship => manager.Championship;

        public IDictionary<string, bool> FavPlayers { get; set; } = new Dictionary<string, bool>();

        public MainForm()
        {
            SetCulture();
            InitializeComponent(); 
        }

        private void SetCulture()
        {
            string language = settingsManager.CheckForLanguage() ? "hr" : "en";
            CultureInfo culture = new CultureInfo(language);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        //Main form logic
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillFavoritePlayers();
            try
            {
                if (!File.Exists(PathConstants.Settings))
                {
                    ShowSettingsForm();
                }
                else
                {
                    SetForm();
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.fileException);
                return;
            }
        }

        public void SetForm()
        {
            SetCulture();
            this.Controls.Clear();
            InitializeComponent();
            FillDdl();
        }

        private async void FillDdl()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                var teams = await manager.GetAllTeams();
                teams.ToList().ForEach(t => ddlTeams.Items.Add(t));

                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.teamLoading);
                return;
            }

            SelectedTeam = settingsManager.SetFavoriteTeam(Championship);
            if (SelectedTeam == string.Empty)
            {
                ddlTeams.SelectedIndex = -1;
            }
            else
                ddlTeams.SelectedIndex = ddlTeams.FindStringExact(SelectedTeam);
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
                this.Cursor = Cursors.WaitCursor;

                players = await manager.GetPlayers(GetFifaCode());
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

                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.playerLoading);
                return;
            }
        }

        //Drag and drop
        private void Panels_DragEnter(object sender, DragEventArgs e)
        {
            List<PlayerUC> multiDnD = e.Data.GetData(typeof(List<PlayerUC>)) as List<PlayerUC>;

            Control parent = multiDnD[0].Parent;
            var startingPanel = (FlowLayoutPanel)sender;

            var nmbrOfFavorites = pnlFavoritePlayers.Controls.Count + multiDnD.Count();

            

            if (startingPanel != parent)
            {
                if (parent.Name == pnlFavoritePlayers.Name)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else if (nmbrOfFavorites <= 3)
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                    e.Effect = DragDropEffects.None;
            }
            else 
                e.Effect = DragDropEffects.None;
            
        }

        private void pnlPlayers_DragDrop(object sender, DragEventArgs e)
        {
            var dropPanel = (FlowLayoutPanel)sender;
            List<PlayerUC> dropList = e.Data.GetData(typeof(List<PlayerUC>)) as List<PlayerUC>;

            if (dropPanel == pnlPlayers)
            {
                foreach (var puc in dropList)
                {
                    puc.PlayerInUC.Favorite = !puc.PlayerInUC.Favorite;
                    puc.CheckFavorite();
                }

                dropList.ForEach(puc => pnlPlayers.Controls.Add(puc));
  
            }

            else if (dropPanel == pnlFavoritePlayers)
            {
                foreach (var puc in dropList)
                {
                    puc.PlayerInUC.Favorite = !puc.PlayerInUC.Favorite;
                    puc.CheckFavorite();
                }

                dropList.ForEach(puc => pnlFavoritePlayers.Controls.Add(puc));
            }

        }

        //Players and PlayerUC logic
        public void MovePlayerControl(PlayerUC playerUC)
        {
            if (playerUC.Parent == pnlPlayers)
            {
                if (pnlFavoritePlayers.Controls.Count >= 3)
                {
                    MyException.ShowMessage(Resources.Messages.favoriteMessage);
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

            playerUC.CheckFavorite();
            SaveFavorites();
        }

        //Settings logic
        private void btnSettings_Click(object sender, EventArgs e) => ShowSettingsForm();

        private void ShowSettingsForm()
        {
            SaveSelectedTeam();
            var settingsForm = new SettingsForm(this);
            settingsForm.TopMost = true;
            settingsForm.ShowDialog();
        }

        //Statistics form call
        private async void btnOpenStatisticsForm_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                matches = await manager.GetAllMatches(GetFifaCode());
                StatisticsForm statisticsForm = new StatisticsForm(matches, players);
                statisticsForm.ShowDialog();

                this.Cursor = Cursors.Default;
            }
            catch (Exception)
            {
                MyException.ShowMessage(Resources.Messages.statisticsMessage);
                return;
            }
        }

        //Properties setting
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ddlTeams.SelectedIndex == -1)
            {
                Application.Exit();
            }
            else SaveSelectedTeam();
        }
        private void FillFavoritePlayers() => FavPlayers = settingsManager.FillFavoritePlayers(FavPlayers);

        private void SetSelectedTeam() => SelectedTeam = ddlTeams.SelectedItem.ToString();

        private void SaveFavorites() => settingsManager.SaveFavoritePlayers(FavPlayers);

        private void SaveSelectedTeam() => settingsManager.SaveFavoriteTeam(Championship, SelectedTeam);

        private string GetFifaCode() => SelectedTeam.Substring(SelectedTeam.LastIndexOf('(') + 1, 3);
    }
}