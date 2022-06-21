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
        public string Championship => GetChampionship();

        private string GetChampionship()
        {
            if (rbMale.Checked)
            {
                return "Men";
            }
            else
                return "Women";
        }

        public bool Language => GetLanguage();

        private bool GetLanguage()
        {
            if (rbFemale.Checked)
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

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
