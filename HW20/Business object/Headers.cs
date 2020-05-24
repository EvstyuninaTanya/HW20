using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.Business_object
{
    public class Headers
    {
        public string allproducts { get; set; }
        public string HeaderHP { get; set; }
        public string HeaderLogin { get; set; }
        public string HeaderLogout { get; set; }

        public Headers (string allproducts, string HeaderHP, string HeaderLogin, string HeaderLogout)
        {
            this.allproducts = allproducts;
            this.HeaderHP = HeaderHP;
            this.HeaderLogin = HeaderLogin;
            this.HeaderLogout = HeaderLogout;
        }
    }
}
