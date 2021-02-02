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
    public partial class CategoriesModalPage : ContentPage
    {
       

        public CategoriesModalPage()
        {
            InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        async void OnAddCategoryButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryDescriptionEntry.Text))
            {
                await App.Database.SaveCategoryAsync(new CustomerCategory
                {
                    Description = categoryDescriptionEntry.Text
                                
                });

                categoryDescriptionEntry.Text = string.Empty;

                
            }
        }

        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }
     }
}