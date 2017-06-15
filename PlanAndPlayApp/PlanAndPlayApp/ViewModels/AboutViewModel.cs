using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About Kauz Informatik | Medien AG";

            OpenWebCommandAbout = new Command(() => Device.OpenUri(new Uri("http://www.kauz.ch/")));

            OpenWebCommandPlanAndPlay = new Command(() => Device.OpenUri(new Uri("https://www.moneyhouse.ch/de/company/plan-play-ag-13984589621")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommandAbout { get; }
        public ICommand OpenWebCommandPlanAndPlay { get; }
    }
}
