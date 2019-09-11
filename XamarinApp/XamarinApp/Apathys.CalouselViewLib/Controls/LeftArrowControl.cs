using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using static Apathys.CalouselViewLib.Resources.ResourcesInfo;

namespace Apathys.CalouselViewLib.Controls
{
    public class LeftArrowControl : ArrowControl
    {
        public LeftArrowControl()
        {
            IsRight = false;
            AbsoluteLayout.SetLayoutBounds(this, new Rectangle(0, .5, -1, -1));
        }

        protected override ImageSource DefaultImageSource => WhiteLeftArrowImageSource;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static void Preserve()
        {
        }
    }
}
