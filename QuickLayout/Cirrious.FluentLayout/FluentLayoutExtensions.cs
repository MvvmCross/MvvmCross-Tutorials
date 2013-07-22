// FluentLayoutExtensions.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System.Collections.Generic;
using System.Linq;
using MonoTouch.UIKit;

namespace Cirrious.FluentLayouts
{
    public static class FluentLayoutExtensions
    {
        public static void SubviewsDoNotTranslateAutoresizingMaskIntoConstraints(this UIView view)
        {
            foreach (var subview in view.Subviews)
            {
                subview.TranslatesAutoresizingMaskIntoConstraints = false;
            }
        }

        public static UIViewAndLayoutAttribute Left(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Left);
        }

        public static UIViewAndLayoutAttribute Right(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Right);
        }

        public static UIViewAndLayoutAttribute Top(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Top);
        }

        public static UIViewAndLayoutAttribute Bottom(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Bottom);
        }

        public static UIViewAndLayoutAttribute Baseline(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Baseline);
        }

        public static UIViewAndLayoutAttribute Trailing(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Trailing);
        }

        public static UIViewAndLayoutAttribute Leading(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Leading);
        }

        public static UIViewAndLayoutAttribute CenterX(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.CenterX);
        }

        public static UIViewAndLayoutAttribute CenterY(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.CenterY);
        }

        public static UIViewAndLayoutAttribute Height(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Height);
        }

        public static UIViewAndLayoutAttribute Width(this UIView view)
        {
            return view.WithLayoutAttribute(NSLayoutAttribute.Width);
        }

        public static UIViewAndLayoutAttribute WithLayoutAttribute(this UIView view, NSLayoutAttribute attribute)
        {
            return new UIViewAndLayoutAttribute(view, attribute);
        }

        public static IEnumerable<FluentLayout> FullWidthWithMargin(this UIView view, UIView parent, float margin)
        {
            yield return view.Left().EqualTo().LeftOf(parent).Plus(margin);
            yield return view.Right().EqualTo().RightOf(parent).Minus(margin);
        }

        public static IEnumerable<FluentLayout> FullHeightWithMargin(this UIView view, UIView parent, float margin)
        {
            yield return view.Top().EqualTo().TopOf(parent).Plus(margin);
            yield return view.Bottom().EqualTo().BottomOf(parent).Minus(margin);
        }

        public static void AddConstraints(this UIView view, params FluentLayout[] fluentLayouts)
        {
            view.AddConstraints(fluentLayouts
                                    .SelectMany(fluent => fluent.ToLayoutConstraints())
                                    .ToArray());
        }

        public static void AddConstraints(this UIView view, IEnumerable<FluentLayout> fluentLayouts)
        {
            view.AddConstraints(fluentLayouts
                                    .SelectMany(fluent => fluent.ToLayoutConstraints())
                                    .ToArray());
        }
    }
}