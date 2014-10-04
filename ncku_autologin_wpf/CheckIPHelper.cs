using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ncku_autologin_wpf
{
    public class CheckIPHelper
    {
        public void getIPNow()
        {
            IPHostEntry IPHost = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

             

            //foreach (var ipAddress in IPHost.AddressList)
            //{

            //    txt.Text = ipAddress.ToString();

            //}
        }


    }
}
