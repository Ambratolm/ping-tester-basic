using System.Net.NetworkInformation;
using System.Net;

namespace PingTesterBasic
{
    public class PingManager
    {
        private Ping _ping = new Ping();

        public string HostName { get; set; }
        public string HostIPAddress 
        {
            get
            {
                try
                {
                    return Dns.GetHostEntry(this.HostName).AddressList[0].ToString();
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        public PingManager(string hostName = "google.co.ma")
        {
            this.HostName = hostName;
        }

        public PingStatus GetPingStatus()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return new PingStatus(-1);
            }
            else
            {
                try
                {
                    PingReply pingReply = _ping.Send(HostName);
                    if (pingReply.Status != IPStatus.Success)
                    {
                        return new PingStatus(-1);
                    }
                    else
                    {
                        return new PingStatus(pingReply.RoundtripTime);
                    }
                }
                catch
                {
                    return new PingStatus(-1);
                }
            }
        }
    }
}
