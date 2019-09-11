using System;
using Xamarin.Forms;

namespace XamarinAppLib
{
    public class DemoApp: Application
    {
        public DemoApp()
        {

            //MainPage = new NavigationPage(new AppDemoPage());
            //MainPage = new Views.HomePage();
            MainPage = new MainAppPage();
        }
    }
}
