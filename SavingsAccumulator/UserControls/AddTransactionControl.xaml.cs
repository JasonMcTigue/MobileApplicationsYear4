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
        public AddTransactionControl()
        {
            this.InitializeComponent();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearTxtBox();
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //Updates all the fields
            var newTransaction = new Transaction();
            newTransaction.Date = DateTime.Now;
            newTransaction.Amount = Convert.ToDecimal(AmtTxtBox);
            newTransaction.TargetId = _targetId;
            DataContextHelper.AddRecord<Transaction>(newTransaction);

            ClearTxtBox();
        }

        private void SetTargetId(int id) {
            _targetId = id; //sets the target id so the program knows that the id is associased with that transaction
        }

        private void ClearTxtBox() {
            AmtTxtBox.Text = string.Empty;//clears all text from the text box
        }
    }
}
