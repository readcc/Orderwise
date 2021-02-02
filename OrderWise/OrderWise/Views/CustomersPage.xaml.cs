using OrderWise.Models;
using OrderWise.Services;
using OrderWise.ViewModels;
using OrderWise.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderWise.Views
{
    public partial class CustomersPage : ContentPage
    {
        CustomersViewModel _viewModel;

        public CustomersPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CustomersViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetCustomerAsync();

        }

        void OnAddCustomerButtonClicked(object sender, EventArgs e)
        {

            var modalPage = new CustomersModalPage();

            Navigation.PushModalAsync(modalPage);

        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var current = (e.CurrentSelection.FirstOrDefault() as Customer)?.CustomerId;
            var modalPage = new CustomersModalPage();
            Navigation.PushModalAsync(modalPage);
        }

    }   
}