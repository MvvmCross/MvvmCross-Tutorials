// AdvancedFluentLayoutExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections.Generic;
using MonoTouch.UIKit;

namespace Cirrious.FluentLayouts
{
    public static class AdvancedFluentLayoutExtensions
    {
        public static IEnumerable<FluentLayout> VerticalStackPanelConstraints(this UIView parentView, float marginLeft,
                                                                              float marginTop, float marginRight,
                                                                              float marginBottom,
                                                                              float marginBetweenItems,
                                                                              params UIView[] views)
        {
            UIView previous = null;
            foreach (var view in views)
            {
                yield return view.Left().EqualTo().LeftOf(parentView).Plus(marginLeft);
                yield return view.Width().EqualTo().WidthOf(parentView).Minus(marginRight + marginLeft);
                if (previous != null)
                    yield return view.Top().EqualTo().BottomOf(previous).Plus(marginTop);
                else
                    yield return view.Top().EqualTo().TopOf(parentView).Plus(marginTop);
                previous = view;
            }
            if (parentView is UIScrollView)
                yield return previous.Bottom().EqualTo().BottomOf(parentView).Minus(marginBottom);
        }
    }
}