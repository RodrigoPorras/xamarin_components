﻿using System;
using System.Collections.Generic;
using ExploringXamarinComponents.Models;
using Xamarin.Forms;

namespace ExploringXamarinComponents.Pages
{
    public partial class DBViewer : ContentPage
    {
        public DBViewer()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(ageEntry.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Age = int.Parse(ageEntry.Text)
                });

                nameEntry.Text = ageEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
    }
}
