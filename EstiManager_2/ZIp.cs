using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EstiManager_2
{
    public partial class ZIp : Form
    {
        public ZIp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wait wait = new Wait();
            wait.Show();
            Close();
            Compress.compressPatch();
            //Thread waitThread = new Thread(new ThreadStart(Compress.compressPatch));
            //Thread windThread = new Thread(new ThreadStart(wait.Show));
            //waitThread.Start();
            //windThread.Start();
            //Close();
        }

        private void ZIp_Load(object sender, EventArgs e)
        {

        }
    }
}
