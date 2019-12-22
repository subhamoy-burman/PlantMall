using System;
using System.Collections.Generic;
using ArtPlantMall.Local.ViewModels;
using Xamarin.Forms;

namespace ArtPlantMall.Local.Views
{
    public partial class ArtPlantMallView : ContentPage
    {
        double _pageHeight;
        const uint AnimationDuration = 500;
        public ArtPlantMallView()
        {
            InitializeComponent();
            BindingContext = new ArtPlantMallViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CartPopup.OnExpand += OnExpand;
            CartPopup.OnCollapse += OnCollapse;
        }

        private void OnCollapse()
        {
            var yTranslate = _pageHeight - CartPopup.PageHeader;
            CartPopup.TranslateTo(0, yTranslate, AnimationDuration, Easing.SinInOut);
        }

        private void OnExpand()
        {
            var height = _pageHeight - CartPopup.PageHeader;
            CartPopup.TranslateTo(0, Height - height, AnimationDuration, Easing.SinInOut);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CartPopup.OnExpand -= OnExpand;
            CartPopup.OnCollapse -= OnCollapse;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            _pageHeight = height;
            CartPopup.TranslationY = _pageHeight - CartPopup.PageHeader;
            base.OnSizeAllocated(width, height);
        }
    }
}
