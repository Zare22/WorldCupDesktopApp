using Newtonsoft.Json;
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

namespace WorldCupWindowsForms
{
    public partial class MainForm : Form
    {
        DataManager manager = new DataManager();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var teams = manager.TeamsFromResults;
            foreach (var t in teams)
            {
                ddlTeams.Items.Add(t.ToString());
            }
        }

        private void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPlayers.Items.Clear();
            string team = ddlTeams.SelectedItem.ToString();

            manager.Team = team.Substring(0, team.LastIndexOf('('));
            var players = manager.Players;

            foreach (var p in players)
            {
                lbPlayers.Items.Add(p.Name);
            }
            
        }
    }
}
