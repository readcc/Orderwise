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
    public partial class CustomersEditModalPage : ContentPage
    {
        

        public CustomersEditModalPage()
        {
            InitializeComponent();

           
        }


    protected override async void OnAppearing()
        {
            base.OnAppearing();
            customerCategoryPicker.ItemsSource = await App.Database.GetCategoriesAsync();
        }

        async public void OnUpdateCustomerButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(customerNameEntry.Text) 
                && !string.IsNullOrWhiteSpace(telephoneEntry.Text) 
                && !string.IsNullOrWhiteSpace(cellphoneEntry.Text) 
                && !string.IsNullOrWhiteSpace(address1Entry.Text) 
                && !string.IsNullOrWhiteSpace(address2Entry.Text) 
                && !string.IsNullOrWhiteSpace(address3Entry.Text)
                && !string.IsNullOrWhiteSpace(address4Entry.Text)
                && !string.IsNullOrWhiteSpace(postalCodeEntry.Text))
            {
                await App.Database.UpdateCustomerAsync(new Customer
                {
                    CustomerId = int.Parse(customerIdEntry.Text),
                    CustomerCode = customerCodeEntry.Text,
                    CustomerName = customerNameEntry.Text,
                    Telephone = telephoneEntry.Text,
                    Cellphone = cellphoneEntry.Text,
                    Address1 = address1Entry.Text,
                    Address2 = address2Entry.Text,
                    Address3 = address3Entry.Text,
                    Address4 = address4Entry.Text,
                    PostalCode = postalCodeEntry.Text,
                    CustomerCategoryId = customerCategoryPicker.SelectedIndex

                });

                customerCodeEntry.Text =
                customerNameEntry.Text = 
                telephoneEntry.Text = 
                cellphoneEntry.Text =
                address1Entry.Text =
                address2Entry.Text =
                address3Entry.Text =
                address4Entry.Text =
                postalCodeEntry.Text =
                string.Empty;
                customerCategoryPicker.SelectedIndex = -1;

                
            }
            await Navigation.PopModalAsync();
        }

        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }

        void OnDeleteCustomerButtonClicked(object sender, EventArgs e)
        {
             App.Database.DeleteCustomerAsync(new Customer
            {
                CustomerId = int.Parse(customerIdEntry.Text)
            });
                Navigation.PopModalAsync();
        }


        void OnNewOrderButtonClicked(object sender, EventArgs e)
        {

            Navigation.PushModalAsync(new OrdersModalPage());
        }
    }
}