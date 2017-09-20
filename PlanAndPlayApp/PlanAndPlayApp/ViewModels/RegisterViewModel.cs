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
