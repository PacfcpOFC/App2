﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Bloxcrosoft.UI.ViewModels.Menu;

namespace Bloxcrosoft.UI.Elements.Menu.Pages
{
    /// <summary>
    /// Interaction logic for InstallationPage.xaml
    /// </summary>
    public partial class InstallationPage
    {
        public InstallationPage()
        {
            DataContext = new InstallationViewModel();
            InitializeComponent();
        }
    }
}
