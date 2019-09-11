﻿using Apathys.CalouselViewLib.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Apathys.CalouselViewLib
{
    public class CarouselView : CardsView
    {
        public CarouselView() : this(new BaseCarouselFrontViewProcessor(), new BaseCarouselBackViewProcessor())
        {
        }

        public CarouselView(ICardProcessor frontViewProcessor, ICardBackViewProcessor backViewProcessor) : base(frontViewProcessor, backViewProcessor)
        {
            IsClippedToBounds = true;
        }

        protected override double DefaultMoveWidthPercentage => .3;

        protected override bool DefaultIsCyclical => true;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new static void Preserve()
        {
        }
    }
}