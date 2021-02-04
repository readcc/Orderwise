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
    public partial class ProductsPage : ContentPage
    {
        ProductsViewModel _viewModel;

        public ProductsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ProductsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetProductAsync();
        }

        void OnAddProductButtonClicked(object sender, EventArgs e)
        {

            var modalPage = new ProductsModalPage();
            
            Navigation.PushModalAsync(modalPage);
            
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushModalAsync(new ProductsEditModalPage
            {
                BindingContext = e.CurrentSelection.FirstOrDefault() as Product
            });
        }
    }
}