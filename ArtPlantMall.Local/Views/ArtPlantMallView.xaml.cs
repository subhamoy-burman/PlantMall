using System;
using System.Collections.Generic;
using ArtPlantMall.Local.ViewModels;
using Xamarin.Forms;

namespace ArtPlantMall.Local.Views
{
    public partial class ArtPlantMallView : ContentPage
    {
        double _pageHeight;
        public ArtPlantMallView()
        {
            InitializeComponent();
            BindingContext = new ArtPlantMallViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            _pageHeight = height;
            CartPopup.TranslationY = _pageHeight - CartPopup.PageHeader;
            base.OnSizeAllocated(width, height);
        }
    }
}
