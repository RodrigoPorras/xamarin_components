using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ExploringXamarinComponents.Pages
{
    public partial class MEditor : ContentPage
    {
        public MEditor()
        {
            InitializeComponent();
        }

        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }
    }
}
