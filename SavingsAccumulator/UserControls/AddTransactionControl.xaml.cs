using SavingsAccumulator.DataContext;
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
    public sealed partial class AddTransactionControl : UserControl
    {
        public int _targetId;


        public int TargetId {
            get {
                return (int)GetValue(TargetIdProperty);
            }
            set {
                SetValue(TargetIdProperty, value);//Gets target id from data binding
            }

        }

        private readonly DependencyProperty TargetIdProperty = DependencyProperty.Register("TargetId", typeof(int), typeof(AddTransactionControl), null);

        //public event EventHandler TransactionSaveFinished;
        public event EventHandler TransactionSaveFinished;
         private void FireTransactionSaveFinished() {
             if (TransactionSaveFinished != null)
                 TransactionSaveFinished(null,null);
         }
         

        public AddTransactionControl()
        {
            this.InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearTxtBox();
            CollapseControl();
        }

        private async void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //Updates all the fields
            var newTransaction = new Transaction();
            newTransaction.Date = DateTime.Now;
            newTransaction.Amount = Convert.ToDecimal(AmtTxtBox.Text);
            newTransaction.TargetId = TargetId;//assosicates target with target id for that transaction 
            await DataContextHelper.AddRecord<Transaction>(newTransaction);

            FireTransactionSaveFinished();//trigegrs this method so new values are saved
            ClearTxtBox();//clears all text boxes
            CollapseControl();//collapse the control so the user can see the main menu with updates targets
        }

        private void SetTargetId(int id) {
            _targetId = id; //sets the target id so the program knows that the id is associased with that transaction
        }

        private void ClearTxtBox() {
            AmtTxtBox.Text = string.Empty;//clears all text from the text box
        }

        private void CollapseControl() {
            Visibility = Visibility.Collapsed;//Collapse menu once so user can return to main menu and see updated Target details.
        }
    }
}
