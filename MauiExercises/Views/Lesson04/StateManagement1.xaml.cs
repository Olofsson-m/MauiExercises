using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MauiExercises.Globals;
using MauiExercises.Models;
using Windows.Devices.Bluetooth;

namespace MauiExercises.Views.Lesson04
{
    public partial class StateManagement1 : ContentPage
    {
        public List<Friend> MyFriends { get; set; }
        public List<City> MyCity;
        public List<NamedColor> MyColor;
        public StateManagement1()
        {
            InitializeComponent();

            MyFriends = Global.Data.Friends.Value;
            var myFriends = MyFriends.Where(f => f.FavoriteColor.Name.Contains("Blue")).ToList();

            BindingContext = this;
            var startMessage = Global.Data.Message;
            var startTime = Global.Data.Time;
        }
    }
}

