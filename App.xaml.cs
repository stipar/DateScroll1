﻿using MauiApp3.Views;

namespace MauiApp3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DatePage();
        }
    }
}