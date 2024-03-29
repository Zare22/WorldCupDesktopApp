﻿using DataLayer.Constants;
using DataLayer.Exceptions;
using DataLayer.Managers;
using System;
using System.IO;
using System.Windows;

namespace WorldCupWPF
{
    public partial class Settings : Window
    {
        private readonly SettingsManager settingsManager = new SettingsManager();
        private MainWindow MainWindow;
        private string Championship => GetChampionship();
        public string MyLanguage => GetLanguage();

        private string GetChampionship() => rbMale.IsChecked.Value ? "Men" : "Women";
        private string GetLanguage() => rbCroatian.IsChecked.Value ? "hr" : "en";


        public Settings(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
        }

        private void Settings_Loaded(object sender, RoutedEventArgs e)
        {
            CheckForResolution();
            CheckForLanguage();
            CheckForChampionshipType();
        }

        private void CheckForResolution()
        {
            if (Properties.Settings.Default.WindowState == WindowState.Maximized)
            {
                ddlResolution.SelectedIndex = 0;
            }
            if (Properties.Settings.Default.Height == 750)
            {
                ddlResolution.SelectedIndex = 1;
            }
            if (Properties.Settings.Default.Height == 900)
            {
                ddlResolution.SelectedIndex = 2;
            }
            if (Properties.Settings.Default.Height == 850)
            {
                ddlResolution.SelectedIndex = 3;
            }
            if (Properties.Settings.Default.WindowState == WindowState.Normal && Properties.Settings.Default.Height == 725)
            {
                ddlResolution.SelectedIndex = -1;
            }

        }

        private void CheckForChampionshipType()
        {
            try
            {
                if (!File.Exists($"{PathConstants.Settings}"))
                {
                    rbMale.IsChecked = false;
                    rbFemale.IsChecked = false;
                }
                else
                {
                    if (settingsManager.CheckForChampionshipType())
                    {
                        rbMale.IsChecked = true;
                    }
                    else
                        rbFemale.IsChecked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage(Properties.Resources.exceptionFile);
                return;
            }
        }

        private void CheckForLanguage()
        {
            try
            {
                if (!File.Exists($"{PathConstants.Settings}"))
                {
                    rbCroatian.IsChecked = true;
                    rbEnglish.IsChecked = false;
                }
                else
                {
                    if (settingsManager.CheckForLanguage())
                    {
                        rbCroatian.IsChecked = true;
                    }
                    else
                        rbEnglish.IsChecked = true;
                }
            }
            catch (Exception)
            {
                MyException.ShowMessage(Properties.Resources.exceptionFile);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (rbMale.IsChecked.Value == false && rbFemale.IsChecked.Value == false)
            {
                MessageBox.Show(Properties.Resources.settingsChoosePlease);
                return;
            }
            else
            {
                SaveSettingsToResources();
                SaveResolutionToResources();
                SaveLanguage();
                RefreshMainWindow();
                Close();
            }
        }

        private void SaveLanguage()
        {
            Properties.Settings.Default.Language = MyLanguage;
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (rbMale.IsChecked.Value == false && rbFemale.IsChecked.Value == false)
            {
                MessageBox.Show(Properties.Resources.settingsChoosePlease);
                return;
            }
            else
            {
                Close();
            }
        }

        private void SaveResolutionToResources()
        {
            switch (ddlResolution.SelectedIndex)
            {
                case 0:
                    SaveToSettings(0, 0, WindowState.Maximized);
                    return;
                case 1:
                    SaveToSettings(800, 900, WindowState.Normal);
                    return;
                case 2:
                    SaveToSettings(900, 1100, WindowState.Normal);
                    return;
                case 3:
                    SaveToSettings(850, 1200, WindowState.Normal);
                    return;
                default:
                    SaveToSettings(750, 1050, WindowState.Normal);
                    break;
            }
        }

        private void SaveToSettings(double height, double width, WindowState windowState)
        {
            Properties.Settings.Default.Height = height;
            Properties.Settings.Default.Width = width;
            Properties.Settings.Default.WindowState = windowState;
            Properties.Settings.Default.Save();
        }

        public void SaveSettingsToResources() => settingsManager.SaveSettingsToResources(Championship, MyLanguage);
        
        private void RefreshMainWindow()
        {
            MainWindow newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            MainWindow.Close();
        }

    }
}
