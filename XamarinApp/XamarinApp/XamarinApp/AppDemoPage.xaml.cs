using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using XamarinApp.Views;

namespace XamarinApp
{
	 
	public partial class AppDemoPage :ContentPage 
    {
		public AppDemoPage()
		{ 
            InitializeComponent ();

            //NavigationPage.SetHasNavigationBar(this, false);
            var page = new HomePage();
            placeholder.Content = page.Content;
            home_img.Source = "icon_home1.png";
            home_txt.TextColor = Color.Green;
        }

        private void Home_Tapped(object sender, EventArgs e)
        {
            var page = new HomePage();
            placeholder.Content = page.Content;
            home_img.Source = "icon_home1.png";
            home_txt.TextColor = Color.Green;
            msg_img.Source="icon_msg.png";
            msg_txt.TextColor = Color.Black;
            buy_img.Source = "icon_buy.png";
            buy_txt.TextColor = Color.Black;
            my_img.Source = "icon_my.png";
            my_txt.TextColor = Color.Black;
        }
        private void Cate_Tapped(object sender, EventArgs e)
        {
            var page = new CatePage();
            placeholder.Content = page.Content;
            home_img.Source = "icon_home.png";
            home_txt.TextColor = Color.Black;
            msg_img.Source = "icon_msg1.png";
            msg_txt.TextColor = Color.Green;
            buy_img.Source = "icon_buy.png";
            buy_txt.TextColor = Color.Black;
            my_img.Source = "icon_my.png";
            my_txt.TextColor = Color.Black;
        }
        private void Study_Tapped(object sender, EventArgs e)
        {
            var page = new LookPage();
            placeholder.Content = page.Content;
            home_img.Source = "icon_home.png";
            home_txt.TextColor = Color.Black;
            msg_img.Source = "icon_msg.png";
            msg_txt.TextColor = Color.Black;
            buy_img.Source = "icon_buy1.png";
            buy_txt.TextColor = Color.Green;
            my_img.Source = "icon_my.png";
            my_txt.TextColor = Color.Black;
        }
        private void My_Tapped(object sender, EventArgs e)
        {
            var page = new MyPage();
            placeholder.Content = page.Content;
            home_img.Source = "icon_home.png";
            home_txt.TextColor = Color.Black;
            msg_img.Source = "icon_msg.png";
            msg_txt.TextColor = Color.Black;
            buy_img.Source = "icon_buy.png";
            buy_txt.TextColor = Color.Black;
            my_img.Source = "icon_my1.png";
            my_txt.TextColor = Color.Green;
        }
    }
}