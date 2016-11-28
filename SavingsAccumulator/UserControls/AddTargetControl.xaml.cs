
using SavingsAccumulator.Model;
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

        private readonly DependencyProperty TargetIdProperty = DependencyProperty.Register("TargetId", typeof(int), typeof(AddTargetControl), null);
        public int TargetId
        {
            get
            {
                return (int)GetValue(TargetIdProperty);
            }
            set
            {
                SetValue(TargetIdProperty, value);//Gets target id from data binding
            }

        }

       

        public event EventHandler <Target> OnTargetSaved;
        public AddTargetControl()
        {

            this.InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var newTarget = new Target(); //creates new object
            newTarget.Name = TargetNameTxtBox.Text;//taking text from text nox and putting it in the object
            newTarget.SavingTarget = Convert.ToInt32(SavedAmtTxtBox.Text);//have to convert string to int
            newTarget.Notes = NotesTxtBox.Text;
            newTarget.Date = DateTime.Now;
            newTarget.CurrentBalance = 0;//starts off at zero
            //newTarget.SavingTarget=0;

            //Runs the fire on target saved event
            FireOnTargetSave(newTarget);
            //FireOnTargetSaveFinihed(newTarget);



            resetTxtBox();
            Visibility = Visibility.Collapsed;
        }


        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            resetTxtBox();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            //closes user control
            Visibility = Visibility.Collapsed;// Brings the user back to the home page 

            resetTxtBox(); //Clears the text boxes of all text.
        }

        private void resetTxtBox() {
            //This method resets all the text boxes when called
            TargetNameTxtBox.Text = string.Empty;
            NotesTxtBox.Text = string.Empty;
            SavedAmtTxtBox.Text = string.Empty;
        }

        //called when ever information needs to be sent to the main page 
        private void FireOnTargetSave(Target newTarget) {
            OnTargetSaved?.Invoke(null, newTarget);
        }
       
    }
}
