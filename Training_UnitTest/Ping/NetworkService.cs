using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Training_UnitTest.DNS;

namespace Training_UnitTest.Ping
{
    public class NetworkService
    {
        private IDNS _dNS;

        public NetworkService(IDNS dNS)
        {
            _dNS = dNS;
        }

        public string SendPing()
        {
            var dnsSuccess = _dNS.SendDNS();

            if (dnsSuccess)
            {
                return "Success: Ping Sent!";
            }

            return "failed: ping not sent!";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }

        public IEnumerable<PingOptions> GetPingOptionsList()
        {
            IEnumerable<PingOptions> pingOptionsList = new[]
            {
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1},
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1},
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1},
                new PingOptions() {
                    DontFragment = true,
                    Ttl = 1}
            };

            return pingOptionsList;
        }



    }
}
