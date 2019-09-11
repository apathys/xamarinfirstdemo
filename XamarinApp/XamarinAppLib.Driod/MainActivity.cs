using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Forms;

namespace XamarinAppLib.Driod
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {  
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            Forms.SetFlags("CollectionView_Experimental");


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new DemoApp());
            //SetContentView(Resource.Layout.activity_main);
        }
    }
}