using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncku_autologin_wpf
{ 
    [Serializable]
    public class LoginInformation
    {
            public string Account
            {
                get;
                set;
            }
            public string Password
            {
                get;
                set;
            }
       
    }
}
