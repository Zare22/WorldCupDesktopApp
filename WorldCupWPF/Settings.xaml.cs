using DataLayer.Managers;
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

namespace WorldCupWPF
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public string Championship => GetChampionship();

        public string MyLanguage => GetLanguage();

        private string GetChampionship() => rbMale.IsChecked.Value ? "Men" : "Women";
        private string GetLanguage() => rbCroatian.IsChecked.Value ? "hr" : "en";

        private readonly SettingsManager settingsManager = new SettingsManager();

        public Settings() => InitializeComponent();

        private void Settings_Loaded(object sender, RoutedEventArgs e)
        {
            CheckForLanguage();
            CheckForChampionshipType();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveSettingsToResources();
            this.DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CheckForChampionshipType()
        {
            if (settingsManager.CheckForLanguage())
            {
                rbCroatian.IsChecked = true;
            }
            else
                rbEnglish.IsChecked = true;
        }

        private void CheckForLanguage()
        {
            if (settingsManager.CheckForLanguage())
            {
                rbCroatian.IsChecked = true;
            }
            else
                rbEnglish.IsChecked = true;
        }

        public void SaveSettingsToResources() => settingsManager.SaveSettingsToResources(Championship, MyLanguage);


    }
}
