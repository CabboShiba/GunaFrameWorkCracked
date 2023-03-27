using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using static GunaPatcher.Program;
namespace GunaPatcher
{
    internal class GetGunaBytes
    {
        public static string GunaPath = null;
        public static bool GetFile()
        {
            const string URL = "https://github.com/CabboLeak/GunaFrameWorkCracked/blob/main/Guna.UI2.dll?raw=true";
            GunaPath = Environment.CurrentDirectory + @"\Guna.UI2.dll";
            try
            {
                if (!File.Exists(GunaPath))
                {
                    Log($"Downloading Guna.UI2.dll from {URL}...", "DOWNLOAD", ConsoleColor.Cyan);
                    File.WriteAllBytes(GunaPath, new WebClient().DownloadData(URL));
                }
                return true;
            }
            catch(Exception ex)
            {
                Log(ex.Message, "ERROR", ConsoleColor.Red);
                return false;
            }
        }
    }
}
