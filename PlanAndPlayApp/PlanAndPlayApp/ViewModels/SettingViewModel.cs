using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanAndPlayApp.ViewModels
{
    public class SettingViewModel : ObservableObject
    {

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
    }
}
