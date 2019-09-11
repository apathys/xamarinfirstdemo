using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Apathys.CalouselViewLib.Processors
{
    public interface ICardBackViewProcessor : ICardProcessor
    {
        void HandleCleanView(IEnumerable<View> views, CardsView cardsView);
    }
}
