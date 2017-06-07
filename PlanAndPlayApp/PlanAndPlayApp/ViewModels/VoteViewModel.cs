using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class VoteViewModel : BaseViewModel
    {
        public VoteViewModel()
        {
            Title = "Vote";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }

        int sliderHappy = 1;
        public int SliederHappy
        {
            get { return sliderHappy; }
            set { SetProperty(ref sliderHappy, value); }
        }
    }
}
