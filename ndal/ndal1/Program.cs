using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Media;
using Microsoft.Win32;
using System.Reflection;

namespace ndal
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool SystemParametersInfo(uint uAction, uint uParam, string lpvParam, uint fuWinIni);

        private const uint SPI_SETDESKWALLPAPER = 0x0014;
        private const uint SPIF_UPDATEINIFILE = 1;
        private const uint SPIF_SENDWININICHANGE = 2;

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //nameSpace = the namespace of your project, located right above your class' name;
            //outDirectory = where the file will be extracted to;
            //internalFilePath = the name of the folder inside visual studio which the files are in;
            //resourceName = the name of the file;
            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                w.Write(r.ReadBytes((int)s.Length));
            }
        }
        static void Main()
        {

            string tempPath = Path.GetTempPath();
            Properties.Resources.wallpaper.Save(tempPath + "\\" + "ndal.png", System.Drawing.Imaging.ImageFormat.Png);

            Extract("ndal",tempPath,"Resources","ndal.wav");
                {
                    System.Threading.Tasks.Task.Run(PlaySound);
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, tempPath + "\\" + "ndal.png", SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ndal());

                }
            }

        private static System.Media.SoundPlayer player = null;

        private static void PlaySound()
        {
            string TempPath = System.IO.Path.GetTempPath();
            string wav = TempPath + "ndal.wav";
            SoundPlayer ndalsound = new SoundPlayer(wav);
            //読み込む
            player = new System.Media.SoundPlayer(wav);

            //次のようにすると、ループ再生される
            player.PlayLooping();

            //次のようにすると、最後まで再生し終えるまで待機する
            //player.PlaySync();
        }
    }
}