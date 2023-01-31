using Launcher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Packet
{
    class GET_USER_INFO_REC
    {
        public static void GetToken()
        {
            SendPacket.SendUI16(131);
            Form_Launcher._token = ReadsPacket.readS(SendPacket.SendAll());
            Texto.Log("SUCCESSFULLY_GET_INFO_02");
        }
    }
}
