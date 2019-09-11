using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Apathys.CalouselViewLib.Controls
{
    public class IndicatorItemView : CircleFrame
    {
        public IndicatorItemView()
        {
            Size = 10;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static void Preserve()
        {
        }
    }
}