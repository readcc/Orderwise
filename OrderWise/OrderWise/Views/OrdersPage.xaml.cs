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
    public partial class OrdersPage : ContentPage
    {
        OrdersViewModel _viewModel;

        public OrdersPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new OrdersViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetOrdersAsync();
        }

        void OnAddOrderButtonClicked(object sender, EventArgs e)
        {

            var modalPage = new OrdersModalPage();
            
            Navigation.PushModalAsync(modalPage);
            
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var current = (e.CurrentSelection.FirstOrDefault() as Order)?.OrderId;
            var modalPage = new OrdersModalPage();

            Navigation.PushModalAsync(modalPage);
        }
    }
}