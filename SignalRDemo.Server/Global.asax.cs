using System;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

namespace SignalRDemo.Server
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.MapHubs(new HubConfiguration
                {
                EnableCrossDomain = true
            });
        }
    }
}