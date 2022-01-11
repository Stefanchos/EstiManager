using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Threading;

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
            Config.firstRun();
            Config.crashBase();

            Application.Run(new Form1());

        }
    }
    public static class ReadConfig
    {
        
        public static string readEstPath()
        {
            string rPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
            int strNum = 0;
            string estPath = Config.Read(rPath, strNum);

            return estPath;
        }
        public static string readUseBase()
        {
            string rPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
            int strNum = 1;
            string useBase = Config.Read(rPath, strNum);

            return useBase;
        }
    }
    class Search
    {
        private string[] files = new string[50];

        public string[] Files  //� ��� ������, ����� ��� ����� ���������� �� ������, ����������� ��� ������. ����� �� ��� ������...
        {
            get {
                string ePath = ReadConfig.readEstPath();
                files = System.IO.Directory.GetFiles(ePath + @"\LSESTIMT", "*.DBS");
                String pch = ePath + @"\LSESTIMT\";
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = files[i].Substring(pch.Length); //������� ���� � ��������
                }
                return this.files;
            }
        
        }
        public string[] bupFiles  //� ��� ������, ����� ��� ����� ���������� �� ������, ����������� ��� ������. ����� �� ��� ������...
        {
            get
            {
                string ePath = ReadConfig.readEstPath();
                files = System.IO.Directory.GetFiles(ePath + @"\LSESTIMT\BACKUP", "*.zip");
                String pch = ePath + @"\LSESTIMT\BACKUP\";
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = files[i].Substring(pch.Length); //������� ���� � ��������
                }
                return this.files;
            }

        }
    }
    class Check
    {
        public static void check_est()
        {
            var procIsRunningEst = Process.GetProcessesByName("Estimate");
            var procIsRunningDb = Process.GetProcessesByName("dbnt1sv");

            if (procIsRunningEst.Length == 1 | procIsRunningDb.Length == 1)
            {
                check_est();
            }
            else
            {
                ZIp f_zip = new ZIp();
                string ePath = ReadConfig.readEstPath();
                string baseName = Config.BaseName();
                File.Move(ePath + @"\LSESTIMT\LSESTIMT.DBS" , ePath + @"\LSESTIMT\" + baseName);
                f_zip.Show();
            }

            
        }

        public static void start()
        {
            string ePath = ReadConfig.readEstPath();
            string Base = ePath + @"\LSESTIMT\LSESTIMT.DBS";
            FileInfo fileInf = new FileInfo(Base);
            if (fileInf.Exists)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = @"D:\Estimate_2.0_774-812\ESTIMATE.exe";
                proc.StartInfo.WorkingDirectory = @"D:\Estimate_2.0_774-812";
                proc.Start();
            }
            else
            {
                start();
            }
        }
    }
    
    
}
