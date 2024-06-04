using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_ChangeThemes
{
    internal class AppTheme
    {

        public static void ChangeTheme(Uri themeUri)
        {
            ResourceDictionary ThemeRD = new ResourceDictionary() { Source = themeUri };

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(ThemeRD);
        }
    }
}
