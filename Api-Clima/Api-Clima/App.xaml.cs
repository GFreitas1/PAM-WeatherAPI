﻿using Microsoft.Maui.Controls;
using WeatherApp.Views;

namespace WeatherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WeatherView();
        }
    }
}