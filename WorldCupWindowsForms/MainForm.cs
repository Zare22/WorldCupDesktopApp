﻿using Newtonsoft.Json;
using RestSharp;
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
using DataLayer.Constants;
using DataLayer.JsonHandling;
using DataLayer.Repository;
using DataLayer.Managers;
using WorldCupWindowsForms.UserControls;

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form
    {
        private readonly Manager manager = new Manager();
        private PlayerUC playerControl;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDdl();
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPlayers.Controls.Clear();
            FillPanelWithPlayersAsync();
        }

        private async void FillPanelWithPlayersAsync()
        {
            string team = ddlTeams.SelectedItem.ToString();
            string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);

            var players = await manager.GetPlayers(fifaCode);

            players.ToList().ForEach(p => pnlPlayers.Controls.Add(playerControl = new PlayerUC(p)));
        }

        private async void FillDdl()
        {
            var teams = await manager.GetAllTeams();
            teams.ToList().ForEach(t => ddlTeams.Items.Add(t));
        }

        private void pnlFavoritePlayers_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PlayerUC)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void pnlFavoritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            var player = (PlayerUC)e.Data.GetData(typeof(PlayerUC));
            pnlFavoritePlayers.Controls.Add(player);
        }
    }
}