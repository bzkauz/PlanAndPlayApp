﻿using PlanAndPlayApp.ViewModels;
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
    public partial class SettingPage : ContentPage
    {
        private SettingViewModel vm;
        public SettingPage()
        {
           InitializeComponent();
            vm = new SettingViewModel(this.Navigation);
            BindingContext = vm;
        }
    }
}
