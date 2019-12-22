using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ArtPlantMall.Local.Views
{
    public partial class CartPopupView : ContentView
    {
        public delegate void TapDelegate();
        public bool IsCardViewExpanded { get; set; }
        public CartPopupView()
        {
            InitializeComponent();
        }

        public double PageHeader { get; set; } = 70;

        public TapDelegate OnExpand;
        public TapDelegate OnCollapse;
        private void OnExpandTapped(object sender, EventArgs e)
        {
            //VisualStateManager.GoToState(ExpandButton, "Expanded");
            if (!IsCardViewExpanded)
            {
                OnExpand?.Invoke();
                IsCardViewExpanded = true;
            }
            else
            {
                OnCollapse?.Invoke();
                IsCardViewExpanded = false;
            }
        }
    }
}
