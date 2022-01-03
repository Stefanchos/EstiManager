using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EstiManager_2
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Search
    {
        private string[] files = new string[50];

        public string[] Files  //В тот момент, когда код формы спрашивает за массив, срабатывает код отсбда. Вроде бы так короче...
        {
            get {
                files = System.IO.Directory.GetFiles("D:\\Estimate_2.0_774-812\\LSESTIMT", "*.DBS");
                String pch = @"D:\Estimate_2.0_774-812\LSESTIMT\";
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = files[i].Substring(pch.Length); //Срезаем путь в названии
                }
                return this.files;
            }
        
        }
    }
    class Check
    {
        public static void check_est()
        {
            var procIsRunning = Process.GetProcessesByName("Estimate");
            
            if (procIsRunning.Length == 1)
            {
                check_est();
            }
            else
            {
                zip f_zip = new zip();
                f_zip.Show();
            }

            
        }
    }
}
