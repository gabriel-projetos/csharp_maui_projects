﻿using App.GRRInnovations.MindfulZen.Views;

namespace App.GRRInnovations.MindfulZen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomeView();
        }
    }
}
