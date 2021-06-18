using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConanExilesModlistManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void appIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void GetInfoButton_Click(object sender, EventArgs e)
        {
            ConanMod mod = new ConanMod(long.Parse(textBox1.Text));
            titleLabel.Text = "Title: " + mod.title;
            urlLabel.Text = "URL: " + mod.url;
        }
    }
}
