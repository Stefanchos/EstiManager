using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Threading;

namespace EstiManager_2
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            try
            {
                string selectedState = comboBox1.SelectedItem.ToString();
                Compress.cBoxSelected = selectedState;
                string ePath = ReadConfig.readEstPath();
                /*File.Move(ePath + @"\LSESTIMT\" + selectedState, ePath + @"\LSESTIMT\LSESTIMT.DBS");*/ //Возможно, стоит перенести в отдельную функцию? Вопрос с переменной
                File.Move(ePath + @"\LSESTIMT\" + selectedState, ePath + @"\LSESTIMT\LSESTIMT.DBS");
                string appdata = Environment.ExpandEnvironmentVariables("%appdata%");
                string wPath = appdata + @"\estConfig.txt";
                string newText = selectedState;
                Config.WriteFileLine(newText, wPath, 2);
                Check.start();

                this.Hide();
                Check.check_est();
            }
            catch (NullReferenceException)
            {
                noSelected noSel = new noSelected();
                noSel.Show();
            }
        }
        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void def_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            Compress.cBoxSelected = selectedState;
            string appdata = Environment.ExpandEnvironmentVariables("%appdata%");
            string wPath = appdata + @"\estConfig.txt";
            string newText = selectedState;
            Config.WriteFileLine(newText, wPath, 3);
        }

        private void rest_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Show();
        }

        private void no_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
