using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConanExilesModlistManager
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
        }
        private void LocationForm_Load(object sender, EventArgs e)
        {
            mainLocationTextbox.Text = Properties.Settings.Default.InstallLocation;
            modlistLocationTextbox.Text = Properties.Settings.Default.ModlistLocation;
        }

        private void mainInstallButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.InstallLocation = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                mainLocationTextbox.Text = folderBrowserDialog1.SelectedPath;
                this.SetModlistLocation(this.findModlistLocation(folderBrowserDialog1.SelectedPath));
            }
        }

        private void modlistLocationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.SetModlistLocation(folderBrowserDialog1.SelectedPath);
            }
        }

        private string findModlistLocation(string mainPath)
        {
            string path = Path.Combine(mainPath, "ConanSandbox\\Mods\\modlist.txt");
            Console.WriteLine(path);
            return path;
        }

        private void SetModlistLocation(string path)
        {
            Properties.Settings.Default.ModlistLocation = path;
            Properties.Settings.Default.Save();
            modlistLocationTextbox.Text = path;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
