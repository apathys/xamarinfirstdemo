using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Apathys.CalouselViewLib.Controls;
using Apathys.CalouselViewLib.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Apathys.CalouselViewLib.Droid.CardsViewRenderer;

[assembly: ExportRenderer(typeof(ParentScrollView), typeof(ParentScrollViewRenderer))]
namespace Apathys.CalouselViewLib.Droid
{
    [Preserve(AllMembers = true)]
    public class ParentScrollViewRenderer : ScrollViewRenderer
    {
        public ParentScrollViewRenderer(Context context) : base(context)
        {
        }

        public override bool OnInterceptTouchEvent(MotionEvent ev)
        {
            return !IsTouchHandled &&
                    base.OnInterceptTouchEvent(ev);
        }
    }
}