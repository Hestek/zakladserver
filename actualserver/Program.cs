using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace actualserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer wssv = new WebSocketServer("ws://127.0.0.1");
        }
    }
}
