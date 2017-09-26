using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class RegisterViewModel
    {
        private INavigation _navigation;
        private static LoginData loginData;

        const string User = "rene.albert308@gmail.com";
        const string pwd = "René1963";
    //   // const string LoginPage = "https://pp.ayra.ch/de";
    //   // const string RegisterPage = "https://pp.ayra.ch/de/dev/TestLogin";
    //    //3b0fc951-854d-4aa1-9593-55c696a64b5d
    //    //d66793e8-c4db-48d2-8470-d656e4103ccf
    //    //ApiTest
    //    //0c85689e-8046-402f-807e-53422edeee77
    //    //ffcd2ed6-f625-4df0-8b9b-f4d2e2259436

    //    {"username":"rene.albert308@gmail.com", "password":"René1963"}
         

            
             
    // {
    //    "token " : "0"
    //    "device" : "devid"
    //    "name" : "devname"
    //}
    // * * /
        public RegisterViewModel(INavigation navitation)
        {
            _navigation = navitation;
        }

        public ICommand CmdBack
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigation.PopAsync();
                });
            }

        }
    }
}
