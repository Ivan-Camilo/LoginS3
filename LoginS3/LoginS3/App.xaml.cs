﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginS3
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new CalculoNotas();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

