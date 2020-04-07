using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ExploringXamarinComponents.Pages;

namespace ExploringXamarinComponents
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Button_Stacklayout_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new StackLayout());
        }

        async void Button_Label_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MLabel());
        }

        async void Button_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MButton());
        }

        async void Button_Entry_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MEntry());
        }
        async void Button_Editor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MEditor());
        }
        async void Button_Image_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MImage());
        }
        async void Button_Grid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MGrid());
        }
        async void Button_ListView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MListView());
        }
        async void Button_Popup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MPopup());
        }
        
    }
}
