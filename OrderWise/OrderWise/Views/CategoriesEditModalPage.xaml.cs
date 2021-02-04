﻿using OrderWise.Models;
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
    public partial class CategoriesEditModalPage : ContentPage
    {
       

        public CategoriesEditModalPage()
        {
            InitializeComponent();

            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        async void OnUpdateCategoryButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryDescriptionEntry.Text))
            {
                await App.Database.UpdateCategoryAsync(new CustomerCategory
                {
                    CustomerCateforyId = int.Parse(categoryIdEntry.Text),
                    Description = categoryDescriptionEntry.Text
                                
                });

               

                await Navigation.PopModalAsync();
            }
        }

        async void OnDeleteCategoryButtonClicked(object sender, EventArgs e)
        {
           
            await App.Database.DeleteCategoryAsync(new CustomerCategory
            {
                CustomerCateforyId = int.Parse(categoryIdEntry.Text)                

            });

            

            await Navigation.PopModalAsync();
            
        }


        void OnCancelModalButtonClicked(object sender, EventArgs e)
        {

            Navigation.PopModalAsync();
        }
     }
}