﻿using System;
using ArtPlantMall.Local.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArtPlantMall.Local
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ArtPlantMallView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
