using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWindowsForms.UserControls
{
    public partial class PlayersUC : UserControl
    {
        public PlayersUC(Player player)
        {
            InitializeComponent();

            lblPlayerName.Text = player.Name;
            lblShirtNumberW.Text = player.ShirtNumber.ToString();
            lblPositionW.Text = player.Position.ToString();
            lblCaptainW.Text = player.IsCaptain ? "Yes" : "No";
        }
    }
}
