using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelsExtensions
{
    public class VME_Login
    {
        private LoginData loginDat;
        string firsttimeToken = string.Empty;
        public VME_Login(string Device, string name)
        {
            loginDat = new LoginData();
            loginDat.Name = name;
            loginDat.Device = Device;
        }

       

        public void SendFirstTimeToken(string Token)
        {
            firsttimeToken = "{" +""+"device :"  + "}"; // to do next
        }

        public string GetAnswerFristTimeToken()
        {
            return "";
        }

        public void SendSecondTime(string Token)
        {
            firsttimeToken = "{" + "" + "device :" + "}"; // to do next
        }

        public string GetAnswerToken()
        {
            return "";
        }
    }
}
