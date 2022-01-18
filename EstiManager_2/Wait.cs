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
    public partial class Wait : Form
    {
        public Wait()
        {
            InitializeComponent();
        }

        private void Wait_Load(object sender, EventArgs e)
        {
            Wait wait = new Wait();
            Thread waitThread = new Thread(new ThreadStart(wait.messenge));
            waitThread.Start();
        }
        private void messenge()
        {
            string[] wait =
            {
                "Носим ящики в архив...",
                "Аккуратно раскладываем по полкам...",
                "Подписываем стелажи...",
                "Убираем мусор...",
                "Осталось совсем немного..."
            };
            foreach (string i in wait)
            {
                this.label1.Text = i;
                Thread.Sleep(3000);
            }
        }
    }
}
