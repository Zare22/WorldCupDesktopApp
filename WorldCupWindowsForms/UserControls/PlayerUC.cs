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
    public partial class PlayerUC : UserControl
    {
        //private Control controlStartedDnD;
        //private bool successDnD;

        public PlayerUC(Player player)
        {
            InitializeComponent();

            lblPlayerName.Text = player.Name;
            lblShirtNumberW.Text = player.ShirtNumber.ToString();
            lblPositionW.Text = player.Position.ToString();
            lblCaptainW.Text = player.IsCaptain ? "Yes" : "No";
            
        }

        private void PlayerUC_MouseDown(object sender, MouseEventArgs e)
        {
            PlayerUC player = (PlayerUC)sender;
            player.DoDragDrop(player, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
