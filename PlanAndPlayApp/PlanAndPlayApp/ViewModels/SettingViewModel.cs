using Helpers;
using PlanAndPlayApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class SettingViewModel : ObservableObject
    {
        private INavigation _navigation;

        public SettingViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
        private bool usedPush;
        public bool UsedPush
        {
            get { return usedPush; }
            set { SetProperty(ref usedPush, value);}
        }

        private double pushInterval =0.5;
        public double PushInterval
        {
            get { return pushInterval; }
            set { SetProperty(ref pushInterval, value); }
        }

        public ICommand CmdRegister
        {
            get
            {
                return new Command(async () =>
                {
                    await _navigation.PushAsync(new RegisterPage());
                });
            }

        }
    }
    
}
