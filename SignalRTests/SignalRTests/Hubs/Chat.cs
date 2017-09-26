using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRTests.Hubs
{
    public class Chat : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {           
            Clients.All.PublicarMensagem(apelido, mensagem);
        }

    }
}