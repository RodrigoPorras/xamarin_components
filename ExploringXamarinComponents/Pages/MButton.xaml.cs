using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExploringXamarinComponents.Pages
{
    public partial class MButton : ContentPage
    {
        public MButton()
        {
            InitializeComponent();
        }


        void OnButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Click me again!";
        }
    }
}
