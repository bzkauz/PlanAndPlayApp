using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
//using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            // SaveCommand = new Command(SendLogin);
            OpenQRCode = new Command(() => Device.OpenUri(new Uri("https://pp.ayra.ch/de")));
        }

        public ICommand OpenQRCode { get; }
        void SendLogin()
        {
            //throw new NotImplementedException();
        }
        void SaveExecute() { }

        bool CanExecute()
        {
            return true;
        }
        public ICommand SaveCommand
        {
            get;
            set; 
        }

    string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }


        string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        

        
    }
}
