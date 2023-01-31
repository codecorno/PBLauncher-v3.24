using Launcher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Packet
{
    class LINK_REC
    {
        public static string Alerta, WEB_Link, AlertaPublicoLink_REC = "";

        public static void run()
        {
            SendPacket.SendUI16(121);
            SendPacket.SendUI16(ConectionClient.LancherTipo);
            SendPacket.SendUI16(5);
            WEB_Link = ReadsPacket.readS(SendPacket.SendAll());
            Texto.Log("SUCCESSFULLY_GET_INFO_01");
        }

    }
}
