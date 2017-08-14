using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Common
    {
        //return the absolute path to the Assets folder
        public static String returnAssetsPath()
        {
            String projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            String assetsPath = projectPath + "/Assets/";
            return assetsPath;
        }

        //if process is running return true, otherwise return false
        public static bool IsRunning(Process process)
        {
            try 
            { 
                Process.GetProcessById(process.Id); 
            }
            catch (InvalidOperationException) 
            { 
                return false; 
            }
            catch (ArgumentException) 
            { 
                return false; 
            }
            return true;
        }

        //return local IP address as a string
        public static string GetLocalIPAddress()
        {
            // https://stackoverflow.com/questions/6803073/get-local-ip-address

            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }
    }
}
