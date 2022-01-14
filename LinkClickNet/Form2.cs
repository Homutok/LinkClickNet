using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LinkClickNet
{
    public partial class Setting_Form : Form
    {
        string defBrowser = "Default";
        string defMode = "Normal";
        public Setting_Form()
        {
            InitializeComponent();
            switch (Properties.Settings.Default.DefaultBrowser)
            {
                case "Chrome":
                    {
                        chrome.Checked = true;
                        break;
                    }
                case "mozilla":
                    {
                        mozilla.Checked = true;
                        break;
                    }
                case "Explorer":
                    {
                        explorer.Checked = true;
                        break;
                    }
                case "Yandex":
                    {
                        yandex.Checked = true;
                        break;
                    }
                case "Opera":
                    {
                        opera.Checked = true;
                        break;
                    }
                case "Edge":
                    {
                        edge.Checked = true;
                        break;
                    }
                default:
                    {
                        browserDefault.Checked = true;
                        break;
                    }
            }
            switch (Properties.Settings.Default.DefaultMode)
            {
                case "Normal":
                    {
                        radioDefault.Checked = true;
                        break;
                    }
                case "Incognito":
                    {
                        incognito.Checked = true;
                        break;
                    }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultBrowser = defBrowser;
            Properties.Settings.Default.DefaultMode = defMode;
            Properties.Settings.Default.Save();
            MessageBox.Show("Настройки сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mozila_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "mozilla";
            incognito.Visible = true;
        }

        private void chrome_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Chrome";
            incognito.Visible = true;
        }

        private void explorer_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Explorer";
            radioDefault.Checked = true;
            incognito.Visible = false;
        }

        private void yandex_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Yandex";
            incognito.Visible = true;
        }

        private void opera_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Opera";
            incognito.Visible = true;
        }

        private void edge_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Edge";
            incognito.Visible = true;
        }

        private void incognito_CheckedChanged(object sender, EventArgs e)
        {
            defMode = "Incognito";
        }

        private void radioDefault_CheckedChanged(object sender, EventArgs e)
        {
            defMode = "Normal";
        }

        private void browserDefault_CheckedChanged(object sender, EventArgs e)
        {
            defBrowser = "Default";
            radioDefault.Checked = true;
            incognito.Visible = false;
        }
    }
}
