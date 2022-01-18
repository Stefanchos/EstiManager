using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;


namespace EstiManager_2
{
    public static class Compress
    {

        public static string cBoxSelected;
        public static void time()
        {
            var TimeNow = DateTime.Now;
            Console.WriteLine(TimeNow);
        }
        public static void compressPatch()
        {
            string TimeNow = DateTime.Now.ToString();
            TimeNow = TimeNow.Replace(":", ".");
            string ePath = ReadConfig.readEstPath();
            string uBase = ReadConfig.readUseBase();
            string pachIn = ePath + @"\LSESTIMT\" + uBase;
            string pachOut = ePath + @"\LSESTIMT\BACKUP\" + uBase + " (" + TimeNow + ")" + ".zip";

            Compress.compress(pachIn, pachOut);
        }
        public static void compress(string pachIn, string pachOut)
        {
            using (FileStream sourceStream = new FileStream(pachIn, FileMode.OpenOrCreate))
            {
                // поток для записи сжатого файла
                using (FileStream targetStream = File.Create(pachOut))
                {
                    // поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream); // копируем байты из одного потока в другой

                    }
                }
            }
            Exit exit = new Exit();
            exit.Show();

        }
        public static void decompress(string pachIn, string pachOut)
        {
            using (FileStream sourceStream = new FileStream(pachIn, FileMode.OpenOrCreate))
            {
                // поток для записи восстановленного файла
                using (FileStream targetStream = File.Create(pachOut))
                {
                    // поток разархивации
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                        
                    }
                }
            }
            

            DcprsOk dcprs = new DcprsOk();
            dcprs.ShowDialog();

        }
    }
}
