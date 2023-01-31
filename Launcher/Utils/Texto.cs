using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher.Utils
{
    public static class Texto
    {
        public static string AppData = Environment.ExpandEnvironmentVariables("%AppData%");

        public static void Log(string texto)
        {
            string str = string.Concat(Application.StartupPath, "\\PBLauncher.log");
            DateTime now = DateTime.Now;
            StreamWriter streamWriter = new StreamWriter(str, true);
            texto = texto == "" ? "" : "[" + now.ToString("yyyy/MM/dd HH:mm") + "] " + texto;
            streamWriter.WriteLine(texto);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
