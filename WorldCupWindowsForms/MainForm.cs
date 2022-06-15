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
        //DataManager manager = new DataManager();
        private readonly TeamManager teamManager = new TeamManager();
        //private readonly IRepository repo = RepositoryFactory.GetRepository();

        public MainForm()
        {
            InitializeComponent();
        }

        //private async void ddlTeams_SelectedIndexChangedAsync(object sender, EventArgs e)
        //{
        //    lbPlayers.Items.Clear();
        //    string team = ddlTeams.SelectedItem.ToString();
        //    string fifaCode = team.Substring(team.LastIndexOf('(') + 1, 3);
        //    //var players = await repo.GetPlayers(fifaCode);
        //    //foreach (var p in players)
        //    //{
        //    //    lbPlayers.Items.Add(p.Name);
        //    //}
        //}

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillDdl();
        }

        private async void FillDdl()
        {
            var teams = await teamManager.GetAllTeams();
            foreach (var t in teams)
            {
                ddlTeams.Items.Add(t);
            }
        }
    }
}