using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCupWindowsForms
{
    public partial class SettingsForm : Form
    {
        public string Championship => SetChampionship();

        private string SetChampionship()
        {
            if (chBoxMale.Checked)
            {
                return "Men";
            }
            else
                return "Women";
        }

        public bool Language => SetLanguage();

        private bool SetLanguage()
        {
            if (chBoxCroatian.Checked)
            {
                return true;
            }
            else
                return false;
        }

        public SettingsForm()
        {
            InitializeComponent();
        }
    }
}
