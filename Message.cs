using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jrpc.NET
{
    class Message
    {
        public JObject jobj;
        public byte[] bytes;
        public static Message Request(int id, string method, object[] args)
        {
            JObject jobj = new JObject();
            jobj["jsonrpc"] = "2.0";
            jobj["id"] = id;
            jobj["method"] = method;
            jobj["params"] = new JArray(new JArray(args), new JObject());
            return new Message(jobj);
        }
        public Message(JObject jobj)
        {

            this.jobj = jobj;
            this.bytes = Encoding.ASCII.GetBytes(jobj.ToString());
        }
        public Message(byte[] bytes)
        {
            this.bytes = bytes;
            Encoding.ASCII.GetString(bytes);
        }
    }
}
