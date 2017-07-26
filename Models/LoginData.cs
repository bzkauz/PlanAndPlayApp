using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LoginData
    {
        public string Url { get; set; }
        public string Token { get; set; }
        public string PWD { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }

    public class LoginFirst
    {  
        public string Token { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }      
    }

    public class LoginFull
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public int code { get; set; }
        public bool success { get; set; }
        public string data { get; set; }
        public string user { get; set; }
    }

    
    public class RootobjectLoging
    {
        public LoginData[] LoginDataObjects { get; set; }
    }


    public static class Constants
    {
        // URL of REST service
        public static string RestUrl = "https://pp.ayra.ch/de";
        // Credentials that are hard coded into the REST service
        public static string Username = "rene.albert@kauz.ch";
        public static string Password = "Password.1616";

        public static string RestUrlLogin = "https://pp.ayra.ch/de";
    }

    public static class ConstantsLogin
    {
        // URL of REST service
        public static string RestUrl = "https://pp.ayra.ch/en/MobileTemplogin";
        // Credentials that are hard coded into the REST service
        public static string Username = "rene.albert@kauz.ch";
        public static string Password = "Password.1616";
        public static string device = "asdf";
        public static string name = "asdf";

    }

    public class REQ
    {
        public string device { get; set; }
        public string token { get; set; }
        public string name { get; set; }
    }

    public class ANS
    {
        public int Code { get; set; }
        public bool success { get; set; }
        public string data { get; set; }

    }

    public class Result
    {
        public int code { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }
}
