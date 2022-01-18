using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstiManager_2
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Config.reFirstWrite();
            string ePath = ReadConfig.readEstPath();
            this.floaderName.Text = ePath;
            
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string ePath = ReadConfig.readEstPath();
            this.floaderName.Text = ePath;
            string setCompress = Config.Read(Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt", 3);
            
            if (setCompress == "1")
            {
                this.checkBox1.Checked = true;
                this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                Config.WriteFileLine("1" , Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt", 4);
            }
            else
            {
                Config.WriteFileLine("0", Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt", 4);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
