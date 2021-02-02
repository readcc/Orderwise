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
    public partial class ProductsModalPage : ContentPage
    {
       

        public ProductsModalPage()
        {
            InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        async void OnAddProductButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(productCodeEntry.Text) && !string.IsNullOrWhiteSpace(productNameEntry.Text))
            {
                await App.Database.SaveProductAsync(new Product
                {
                    ProductCode = productCodeEntry.Text,
                    ProductName = productNameEntry.Text                    
                });

                productCodeEntry.Text = productNameEntry.Text = string.Empty;

                
            }
        }

        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }
     }
}