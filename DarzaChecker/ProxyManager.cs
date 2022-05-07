using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DarzaChecker
{
    public class Proxy
    {
        private string Address { get; set; }
        public bool Banned { get; set; } = false;

        public string NewAddres()
        {
            return this.Address;
        }

        public void BanProxy()
        {
            this.Banned = true;
        }

        public void UnbanProxy()
        {
            this.Banned = false;
        }

        public Proxy(string address)
        {
            this.Address = address;
        }
    }

    class ProxyManager
    {

    }
}
