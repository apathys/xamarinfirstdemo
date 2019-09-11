using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinApp
{
    public partial class AppDemo : Application
    {
        public AppDemo()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new AppDemoPage());
            MainPage =  new AppDemoPage();

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
