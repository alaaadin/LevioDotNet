using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLevio.Hubs
{
    [HubName("NotificationHub")]
    public class NotificationHub : Hub
    {
        public void Send(String name,String message)
        {
            Clients.All.addNewmessageToPage(name, message);
        }
    }
}