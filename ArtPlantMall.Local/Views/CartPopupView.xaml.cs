using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ArtPlantMall.Local.Views
{
    public partial class CartPopupView : ContentView
    {
        public CartPopupView()
        {
            InitializeComponent();
        }

        public double PageHeader { get; set; } = 70;

        private void OnExpandTapped(object sender, EventArgs e)
        {

        }
    }
}
