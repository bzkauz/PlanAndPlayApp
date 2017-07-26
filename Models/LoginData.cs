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

    public class RootobjectLoging
    {
        public LoginData[] LoginDataObjects { get; set; }
    }
}
