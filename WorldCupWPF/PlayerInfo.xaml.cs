using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorldCupWPF.UserControls;

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for PlayerInfo.xaml
    /// </summary>
    public partial class PlayerInfo : Window
    {
        private PlayerUC PlayerUC { get; set; }


        public PlayerInfo(PlayerUC player)
        {
            InitializeComponent();
            PlayerUC = player;
        }

        private void PlayerInfo_Loaded(object sender, RoutedEventArgs e)
        {

            lblName.Content = PlayerUC.PlayerInUC.Name;
            lblNumber.Content = PlayerUC.PlayerInUC.ShirtNumber;
            lblCaptain.Content = PlayerUC.PlayerInUC.IsCaptain ? "Captain" : "No";
            lblPosition.Content = PlayerUC.PlayerInUC.Position;

            lblGoalsScored.Content = PlayerUC.GoalsScored;
            lblYellowCards.Content = PlayerUC.YellowCards;
        }
    }
}
