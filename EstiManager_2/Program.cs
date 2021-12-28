using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Search.Search_cb();                                      //Смотрим папку
            Application.Run(new Form1());
            
            
            foreach(string i in Search.files)
                Console.WriteLine("1 " + i);
        }
    }
    public static class Search
    {
        public static string[] files = new string[50];
        public static void Search_cb()
        {
            
            files = System.IO.Directory.GetFiles("D:\\Estimate_2.0_774-812\\LSESTIMT", "*.DBS");
            Console.WriteLine(files);
            String pch = @"D:\Estimate_2.0_774-812\LSESTIMT\";
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(pch.Length);  //Нужно подумать над удалением расширения, в теории, при условных путях это строка будет не нужна
                /*files[i] = files[i].Substring(0, 4);*/        //Расширение на счиается???
                //a = i.Substring(pch.Length);
                //Console.WriteLine(a);
                //Console.WriteLine(a.Length);
            }
        }
    }
}
