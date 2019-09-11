using Apathys.CalouselViewLib.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Apathys.CalouselViewLib.EventArgs
{
    public class ItemSwipedEventArgs : System.EventArgs
    {
        public ItemSwipedEventArgs(ItemSwipeDirection direction, int index, object item)
        {
            Direction = direction;
            Index = index;
            Item = item;
        }

        public ItemSwipeDirection Direction { get; }
        public object Item { get; }
        public int Index { get; }
    }
}
