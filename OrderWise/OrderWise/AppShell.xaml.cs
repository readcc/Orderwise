using OrderWise.Services;
using OrderWise.ViewModels;
using OrderWise.Views;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace OrderWise
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        
        public AppShell()
        {
            InitializeComponent();

        }
        
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
