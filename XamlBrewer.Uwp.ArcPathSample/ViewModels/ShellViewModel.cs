﻿using Mvvm.Services;
using XamlBrewer.Uwp.ArcPathSample;

namespace Mvvm
{
    internal class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menus
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("HomeIcon"), Text = "Home", NavigationDestination = typeof(HomePage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("CodeIcon"), Text = "XAML", NavigationDestination = typeof(ArcSegmentPage) });
            Menu.Add(new MenuItem() { Glyph = Icon.GetIcon("CodeIcon"), Text = "Win2D", NavigationDestination = typeof(Win2DPage) });
            SecondMenu.Add(new MenuItem() { Glyph = Icon.GetIcon("InfoIcon"), Text = "About", NavigationDestination = typeof(AboutPage) });
        }
    }
}
