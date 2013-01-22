using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Collections.Core.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Collections.WP.Views
{
    public partial class MainMenuView : BaseMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();
        }
    }

    public class BaseMainMenuView : MvxPhonePage<MainMenuViewModel>
    {        
    }
}