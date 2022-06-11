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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TeamManager teamManager = new TeamManager();
            var teams = teamManager.Players;
            foreach (var t in teams)
            {
                comboBox1.Items.Add(t.Name);
            }
            comboBox1.Items.Add(teams.Count());
        }
    }
}
