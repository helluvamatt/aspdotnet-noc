using System.Web;
using XSockets.Core.Common.Socket;

[assembly: PreApplicationStartMethod(typeof(Noc.App_Start.XSocketsBootstrap), "Start")]

namespace Noc.App_Start
{
    public static class XSocketsBootstrap
    {
        private static IXBaseServerContainer wss;
        public static void Start()
        {
            wss = XSockets.Plugin.Framework.Composable.GetExport<IXBaseServerContainer>();
            wss.StartServers();
        }        
    }
}