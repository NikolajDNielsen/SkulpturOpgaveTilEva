using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SkulpturOpgaveTilEva.Tools
{
    public static class Navigate
    {
        public static Frame CurrentPage { get; set; }

        public static void To(Type Page)
        {

            CurrentPage.Navigate(Page);

        }

    }
}
