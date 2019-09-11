using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainAppPage : TabbedPage
    {
        public MainAppPage()
        {
            InitializeComponent();
        }
        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            Title = CurrentPage?.Title;

        }
    }
}
