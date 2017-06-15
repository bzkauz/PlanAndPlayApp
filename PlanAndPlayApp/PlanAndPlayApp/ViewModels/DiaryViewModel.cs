using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanAndPlayApp.ViewModels
{
    public class DiaryViewModel : BaseViewModel
    {
        public DiaryViewModel()
        {
            Title = "Vote";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        /// <summary>
        /// Command to open browser to xamarin.com
        /// </summary>
        public ICommand OpenWebCommand { get; }

        DateTime eventDate = new DateTime(2017, 7, 7, 10, 0, 0);
        public DateTime EventDate
        {
            get { return eventDate; }
            set { SetProperty(ref eventDate, value); }
        }
    }
}
