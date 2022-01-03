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
            string selectedState = comboBox1.SelectedItem.ToString();
            File.Move("D:\\Estimate_2.0_774-812\\LSESTIMT\\" + selectedState, "D:\\Estimate_2.0_774-812\\LSESTIMT\\LSESTIMT.DBS"); //Возможно, стоит перенести в отдельную функцию? Вопрос с переменной
            Process.Start("D:\\Estimate_2.0_774-812\\ESTIMATE.exe");

            Check.check_est();
            //Form1.visible = false;

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
            Close();
        }
    }
}
