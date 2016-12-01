
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using LogLyrics;

namespace LogLyrics
{
    public partial class App : Application
    {
        private MainPage _mainPage;
        public App()
        {
            InitializeComponent();

            _mainPage = new MainPage();
            MainPage = _mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts


        }

      

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
