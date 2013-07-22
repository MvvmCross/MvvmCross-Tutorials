// Priority.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace Cirrious.FluentLayouts
{
    public enum Priority
    {
        Required = 1000,
        DefaultHigh = 750,
        DragThatCanResizeWindow = 510,
        WindowSizeStayPut = 500,
        DragThatCannotResizeWindow = 490,
        DefaultLow = 250,
        FittingSizeCompression = 50,
        None = 0,
    }
}