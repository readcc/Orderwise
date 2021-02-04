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
    public partial class CategoriesPage : ContentPage
    {
        CategoriesViewModel _viewModel;

        public CategoriesPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new CategoriesViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView.ItemsSource = await App.Database.GetCategoriesAsync();
        }

        void OnAddCategoryButtonClicked(object sender, EventArgs e)
        {

            var modalPage = new CategoriesModalPage();
            
            Navigation.PushModalAsync(modalPage);
            
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PushModalAsync(new CategoriesEditModalPage
            {
                BindingContext = e.CurrentSelection.FirstOrDefault() as CustomerCategory
            });
        }
    }
}