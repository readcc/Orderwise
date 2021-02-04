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
    public partial class OrdersModalPage : ContentPage
    {
       

        public OrdersModalPage()
        {
            InitializeComponent();
          

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            customerPicker.ItemsSource = await App.Database.GetCustomerAsync();
        }

        async void OnAddOrderButtonClicked(object sender, EventArgs e)
        {
            if (customerPicker.SelectedIndex !=-1 && !string.IsNullOrWhiteSpace(customerReferenceEntry.Text))
            {
                await App.Database.SaveOrdersAsync(new Order
                {
                    CustomerId = customerPicker.SelectedIndex,
                    OrderDate = orderDatePicker.Date,
                    CustomerReference = customerReferenceEntry.Text
                });

                //productCodeEntry.Text = productNameEntry.Text = string.Empty;

                
            }
        }

        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }
     }
}