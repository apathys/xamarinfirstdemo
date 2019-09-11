using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using static Apathys.CalouselViewLib.Resources.ResourcesInfo;

namespace Apathys.CalouselViewLib.Controls
{
    public class RightArrowControl : ArrowControl
    {
        public RightArrowControl()
        {
            AbsoluteLayout.SetLayoutBounds(this, new Rectangle(1, .5, -1, -1));
        }

        protected override ImageSource DefaultImageSource => WhiteRightArrowImageSource;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static void Preserve()
        {
        }
    }
}
