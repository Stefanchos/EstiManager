using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Linq;


namespace EstiManager_2
{
    class Config
    {
        public static void firstRun()
        {
            string estConfig = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
            FileInfo fileInf = new FileInfo(estConfig);
            if (!fileInf.Exists) 
            {
         
                FolderBrowserDialog FBD = new FolderBrowserDialog();
                if (FBD.ShowDialog() == DialogResult.OK)
                {
                    string sPath = FBD.SelectedPath;
                    string estPath = sPath;
                    string wPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
                    Config.firstWriteFile(wPath, estPath);
                }
                //string estPath = sPath;
                //string wPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
                //Config.firstWriteFile(wPath, estPath);
            }
        }
        public static void crashBase()
        {
            string ePath = ReadConfig.readEstPath();
            string defBase = ePath + @"\LSESTIMT\LSESTIMT.DBS";
            FileInfo fileInf = new FileInfo(defBase);
            if (fileInf.Exists)
            {
                string baseName = Config.BaseName();

                File.Move(ePath + @"\LSESTIMT\LSESTIMT.DBS", ePath + @"\LSESTIMT\" + baseName);
            }
        }
        public static void firstWriteFile(string wPath, string estPath)
        {
            

            using (StreamWriter sw = new StreamWriter(wPath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(estPath);
            }
            Config.WriteFile(wPath, "Преименуйте базу.DBS");
            Config.WriteFile(wPath, "Выбор базы");
            Config.WriteFile(wPath, "1");
            Directory.CreateDirectory(estPath + @"\LSESTIMT\BACKUP");
        }
        public static void WriteFile(string wPath, string savePath)
        {


            using (StreamWriter sw = new StreamWriter(wPath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(savePath);
            }
        }
        public static void WriteFileLine(string newText, string wPath, int lineNum)
        {
            string[] arrLine = File.ReadAllLines(wPath);
            arrLine[lineNum - 1] = newText;
            File.WriteAllLines(wPath, arrLine);
        }
        public static string Read(string rPath, int strNum)
        {
            IEnumerable<string> result = File.ReadLines(rPath).Skip(strNum).Take(1);

            string newString = null;

            foreach (string str in result)
            {
                newString += str;
            }

            return newString;
        }
        public static string BaseName()
        {
            string rPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
            int strNum = 1;
            string baseName = Config.Read(rPath, strNum);

            return baseName;
        }
        public static void reFirstWrite()
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string sPath = FBD.SelectedPath;
                string estPath = sPath;
                string wPath = Environment.ExpandEnvironmentVariables("%appdata%") + @"\estConfig.txt";
                Config.WriteFileLine(estPath, wPath, 1);
                
            }
        }
    }
}
