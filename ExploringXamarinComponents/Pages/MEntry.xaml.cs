using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExploringXamarinComponents.Pages
{
    public partial class MEntry : ContentPage
    {
        public MEntry()
        {
            InitializeComponent();
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
    }
}
