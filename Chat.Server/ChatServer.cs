using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Server
{
    public class ChatServer
    {
        private List<IChatClient> _clients;

        public ChatServer()
        {
            _clients = new List<IChatClient>();
        }

        public void Broadcast(IChatClient client, string message)
        {
            foreach (var chatclient in _clients)
            {
                if (chatclient != client)
                {
                    chatclient.Receive(message);
                }
            }
        }

        public void Register(IChatClient chatclient)
        {
            _clients.Add(chatclient);
        }
    }

}
