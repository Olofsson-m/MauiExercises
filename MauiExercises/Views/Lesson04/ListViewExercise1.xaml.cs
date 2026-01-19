using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MauiExercises.Models;

namespace MauiExercises.Views.Lesson04
{
    public partial class ListViewExercise1 : ContentPage
    {
        public ListViewExercise1()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }

        private async void DataModelList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var city = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", city.ToString(), "Ok");
        }
        
        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            Title += $" {Shell.Current.CurrentState.Location.ToString()}";
        }
    }
}

