﻿using OrderWise.Services;
using System;
using System.IO;
using Xamarin.Forms;

namespace OrderWise
{
    public partial class App : Application
    {
        static SQLiteHelper database;

        public static SQLiteHelper Database
        {
            get
            {
                if (database == null)
                {
                    database = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Orderwise.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            
            MainPage = new AppShell();
        }
        
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
