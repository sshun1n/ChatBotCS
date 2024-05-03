using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace chatbot.core
{
    internal class MessageRequest
    {
        public MessageRequest() 
        {
            this.UserMessage = "Привет!";
            Push();
        }

        public void Push()
        {
            using (FileStream fs = File.Create(@"C:\coding\c#\chatbot\chatbot\core\request.py"))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(this.pycode);
                fs.Write(info, 0, info.Length);
            }
        }
        public string UserMessage { 
            get { return this.userMessage; } 
            set
            {
                this.userMessage = value;
                this.pycode = $"# -*- coding: utf-8 -*-\r\nfrom gradio_client import Client\r\n\r\nclient = Client(\"ysharma/Chat_with_Meta_llama3_8b\")\r\nresult = client.predict(\r\n\t\tmessage=\"{this.userMessage}\",\r\n\t\trequest=0.95,\r\n\t\tparam_3=512,\r\n\t\tapi_name=\"/chat\"\r\n)[11:]\r\n\r\nprint(result)";
            } 
        }

        private string userMessage = string.Empty;
        private string pycode = string.Empty;
    }
}
