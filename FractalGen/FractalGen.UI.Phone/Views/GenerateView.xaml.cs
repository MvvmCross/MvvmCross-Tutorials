using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Cirrious.MvvmCross.WindowsPhone.Views;
using FractalGen.Core.ViewModels;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FractalGen.UI.Phone.Views
{
    public partial class GenerateView : MvxPhonePage
    {
        public GenerateView()
        {
            InitializeComponent();
        }

        private void RefreshButton_OnClick(object sender, EventArgs e)
        {
            ((GenerateViewModel) ViewModel).RestartCommand.Execute(null);
        }
    }
}