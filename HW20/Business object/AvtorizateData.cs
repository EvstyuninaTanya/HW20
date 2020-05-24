using System;
using System.Collections.Generic;
using System.Text;

namespace HW20.Business_object
{
    public class AvtorizateData
    {
         public string SetLogin { get; set; }
         public string SetPassword { get; set; }

         public AvtorizateData(string SetLogin, string SetPassword)
         {
             this.SetLogin = SetLogin;
             this.SetPassword = SetPassword;
         }
    }
}
