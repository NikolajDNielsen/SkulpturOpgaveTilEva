using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SkulpturOpgaveTilEva.Tools;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SkulpturOpgaveTilEva.View

{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RedigerStatue : Page
    {
        public RedigerStatue()
        {
            this.InitializeComponent();
            textBox2.Text = Holder.SelectedSkulptur.Info;


            this.InitializeComponent();
            textBox.Text = Holder.SelectedSkulptur.Note;


            this.InitializeComponent();
            textBox_Name.Text = Holder.SelectedSkulptur.Navn;

            this.InitializeComponent();
            textBox1.Text = Holder.SelectedSkulptur.Placering;

            this.InitializeComponent();
            textBox2_Copy5.Text = Holder.SelectedSkulptur.SkulpturID;





        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
