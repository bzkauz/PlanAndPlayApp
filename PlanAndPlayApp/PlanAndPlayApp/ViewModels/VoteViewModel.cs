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

        private double fitnessInterval = 0.5;
        public double FitnessInterval
        {
            get { return fitnessInterval; }
            set { SetProperty(ref fitnessInterval, value); }
        }

        private double feelingTeamInterval = 0.5;
        public double FeelingTeamInterval
        {
            get { return feelingTeamInterval; }
            set { SetProperty(ref feelingTeamInterval, value); }
        }

        private double fairplayInterval = 0.5;
        public double FairplayInterval
        {
            get { return fairplayInterval; }
            set { SetProperty(ref fairplayInterval, value); }
        }

        private double feelingPersonalInterval = 0.5;
        public double FeelingPersonalInterval
        {
            get { return feelingTeamInterval; }
            set { SetProperty(ref feelingTeamInterval, value); }
        }

        private double refereeOkInterval = 0.5;
        public double RefereeOkInterval
        {
            get { return refereeOkInterval; }
            set { SetProperty(ref refereeOkInterval, value); }
        }

    }
}
