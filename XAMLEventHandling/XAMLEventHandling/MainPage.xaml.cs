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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace XAMLEventHandling
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Toggle.Toggled += Toggle_Toggled;
        }

        private void Toggle_Toggled(object sender, RoutedEventArgs e)
        {
            ShowMessage();
        }

        async void ShowMessage(string message = "You clicked me!")
        {
            var dialog = new MessageDialog(message);
            await dialog.ShowAsync();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            bool? isChecked = (sender as ToggleButton).IsChecked;
            ShowMessage($"Your IsChecked Property Value: [{isChecked}]");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem;
        }
    }
}
