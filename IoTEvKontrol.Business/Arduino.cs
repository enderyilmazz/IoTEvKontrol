using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEvKontrol.Business
{
    public class Arduino
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public string Bilgi { get; set; }

        public string VeriGonderAl()
        {
            System.Net.Sockets.TcpClient tcpClient = new System.Net.Sockets.TcpClient();
            tcpClient.Connect(Ip, Port);
            System.Net.Sockets.NetworkStream netStream = tcpClient.GetStream();
            if (netStream.CanWrite)
            {
                Byte[] sendBytes = Encoding.UTF8.GetBytes(Bilgi);
                netStream.Write(sendBytes, 0, sendBytes.Length);
            }
            else
            {
                tcpClient.Close();
                netStream.Close();
                return "Veri Gönderilemedi!";
            }

            if (netStream.CanRead)
            {
                byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);
                string returndata = Encoding.UTF8.GetString(bytes);
                return returndata;
            }
            else
            {
                tcpClient.Close();
                netStream.Close();
                return "Veri Okunamadı!";
            }
            netStream.Close();
            return "";
        }
    }
}
