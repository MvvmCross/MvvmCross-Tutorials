using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels.Samples.SpecificPositions;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Collections.WP.Views.Samples.SpecificPosition
{
    public partial class SpecificPositions : BaseSpecificPositions
    {
        public SpecificPositions()
        {
            InitializeComponent();
        }
    }

    public partial class BaseSpecificPositions : MvxPhonePage<SpecificPositionsViewModel>
    {        
    }
}