using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;

namespace EstiManager_2
{
    class IniFile
    {
        public void startReWrite()
        {
            string ePath = ReadConfig.readEstPath();
            string path = ePath + @"\Gupta\SQLBase 850\sql.ini";
            string[] readText = File.ReadAllLines(path);
            IniFile ifile = new IniFile();
            int stop = ifile.index(readText, "dbname=DESET,sqlws32") + 1;
            int start = ifile.index(readText, "[dbnt1sv.gui]");
            string[] pathList = ifile.SearchPath();
            ifile.WriteFile(path, readText, 1, 0, false);
            ifile.WriteFile(path, readText, stop, 1, true);
            ifile.WriteFile(path, pathList, pathList.Length, 0, true);
            ifile.WriteFile(path, readText, readText.Length, start, true);
        }
        public string[] SearchPath()
        {

            string estpath = ReadConfig.readEstPath();

            string[] paths = Directory.GetDirectories(estpath, "CE*");

            for (int i = 0; i < paths.Length; i++)
            {
                paths[i] = "dbname=" + paths[i].Substring(estpath.Length + 1) + ",sqlws32"; //Срезаем путь в названии
            }
            return paths;
        }
        public int index(string[] readText, string searchString)
        {
            for (int i = 0; i < readText.Length; i++)
            {
                if (readText[i] == searchString)
                    return i;
            }
            return -1;
        }
        public void WriteFile(string wPath, string[] text, int indexEnd, int indexStart, bool fOrS)
        {
            using (StreamWriter sw = new StreamWriter(wPath, fOrS, Encoding.Default))
            {
                for (int i = indexStart; i < indexEnd; i++)
                    sw.WriteLine(text[i]);
            }

        }
    }
}
