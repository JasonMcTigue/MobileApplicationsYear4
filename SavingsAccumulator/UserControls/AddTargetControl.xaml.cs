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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace SavingsAccumulator.UserControls
{
    public sealed partial class AddTargetControl : UserControl
    {
        public AddTargetControl()
        {
            this.InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }


        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            resetTxtBox();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;// Brings the user back to the home page 

            resetTxtBox(); //Clears the text boxes of all text.
        }

        private void resetTxtBox() {
            //This method resets all the text boxes when called
            TargetNameTxtBox.Text = string.Empty;
            NotesTxtBox.Text = string.Empty;
            SavedAmtTxtBox.Text = string.Empty;
        }

       
    }
}
