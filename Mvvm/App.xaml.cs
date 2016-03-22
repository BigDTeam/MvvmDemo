﻿using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace Mvvm
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }
}
