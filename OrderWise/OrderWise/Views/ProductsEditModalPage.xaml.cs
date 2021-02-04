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
    public partial class ProductsEditModalPage : ContentPage
    {
       

        public ProductsEditModalPage()
        {
            InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        async void OnUpdateProductButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(productCodeEntry.Text) && !string.IsNullOrWhiteSpace(productNameEntry.Text))
            {
                await App.Database.UpdateProductAsync(new Product
                {
                    ProductId = int.Parse(productIdEntry.Text),
                    ProductCode = productCodeEntry.Text,
                    ProductName = productNameEntry.Text                    
                });

                await Navigation.PopModalAsync();


            }
        }

        async void OnDeleteProductButtonClicked(object sender, EventArgs e)
        {

            await App.Database.DeleteProductAsync(new Product
            {
                ProductId = int.Parse(productIdEntry.Text)

            });



            await Navigation.PopModalAsync();

        }

        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }
     }
}