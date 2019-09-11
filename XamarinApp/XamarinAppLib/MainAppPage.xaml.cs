using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppLib.ViewModels;

namespace XamarinAppLib
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainAppPage : ContentPage
    {
        HomeViewModel _vm = null;
        public MainAppPage()
        {
            InitializeComponent();
            BindingContext = _vm = new HomeViewModel();
        }
    }
}