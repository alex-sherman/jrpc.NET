using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace jrpc.NET
{
    public class SocketProxy
    {
        private Socket socket;
        public SocketProxy(int port, string host = "localhost", int timeout = 1) {
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(host, port);
        }
        private string _call(string name, params object[] args)
        {
            byte[] bytes = Message.Request(0, name, args).bytes;
            byte[] length = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(bytes.Length));
            socket.Send(length);
            socket.Send(bytes);
            socket.Receive(length, 4, SocketFlags.None);
            int recLength = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(length, 0));
            byte[] recBuffer = new byte[recLength];
            socket.Receive(recBuffer, recLength, SocketFlags.None);
            string rec = Encoding.ASCII.GetString(recBuffer);
            return rec;
        }
        public JToken call(string name, params object[] args)
        {
            return JToken.Parse(_call(name, args))["result"];
        }
        public T call<T>(string name, params object[] args) {
            JToken result = call(name, args);
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(result));
        }
    }
}
