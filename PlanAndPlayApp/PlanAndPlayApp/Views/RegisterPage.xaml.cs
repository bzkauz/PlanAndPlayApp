using PlanAndPlayApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlanAndPlayApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        RegisterViewModel vm;
        public RegisterPage()
        {
            
            InitializeComponent();
            vm = new RegisterViewModel(this.Navigation);
            BindingContext = vm;
        }
    }
}