using System;
using System.Net;
using System.Net.Sockets;

namespace LANLink
{
    public static class NetworkManager
    {
        /// <summary>
        /// جلب عنوان الـ IPv4 المحلي للشبكة الفعلية (Wi-Fi / Ethernet)
        /// </summary>
        public static string GetLocalIPAddress()
        {
            try
            {
                // محاولة الاتصال بـ DNS وهمي للحصول على الـ IP المستخدم حالياً في الشبكة
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
                {
                    socket.Connect("8.8.8.8", 65530);
                    IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                    if (endPoint != null)
                    {
                        return endPoint.Address.ToString();
                    }
                }
            }
            catch
            {
                // في حال عدم وجود اتصال خارجي، يتم الفحص التلقائي لمحول الشبكة المحلي
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip))
                    {
                        return ip.ToString();
                    }
                }
            }

            return "127.0.0.1"; // Default Loopback
        }
    }
}