using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheURLChecker.WinFormsLegacy
{
    public partial class Form1 : Form
    {
        private UrlChecker _urlChecker = new UrlChecker();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_urlChecker.CheckUrl(textBox1.Text))
            {
                textBox1.BackColor = Color.Green;
                Uri uri = new Uri(textBox1.Text);
                textBoxHost.Text = uri.Host;
                textBoxPath.Text = uri.LocalPath;
            } 
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
}
