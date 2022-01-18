using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstiManager_2
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recover_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string[] words = selectedState.Split(new char[] { ' ' });
            string endTime = words[words.Length - 2] + " " + words[words.Length - 1];
            string rBase = selectedState.Replace(endTime , "");
            string ePath = ReadConfig.readEstPath();
            string pachIn = ePath + @"\LSESTIMT\BACKUP\" + selectedState;
            string pachOut = ePath + @"\LSESTIMT\" + rBase;

            Compress.decompress(pachIn, pachOut);
        }
    }
}
