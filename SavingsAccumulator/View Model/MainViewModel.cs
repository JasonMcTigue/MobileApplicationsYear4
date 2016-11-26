using SavingsAccumulator.ButtonCommand;
using SavingsAccumulator.DataContext;
using SavingsAccumulator.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccumulator.View_Model
{

    public class MainViewModel : baseViewModel //inherits base view model
    {
        public ButtonCommands TransactionButtonCommand { get; set; }
        public List<Target> TargetList {
            get { return DataContextHelper.GetTable<Target>(); }
        }

        //This class is needed to show the transaction control
        private bool _showTransactionControl = false;
        public bool ShowTransactionControl {
            get { return _showTransactionControl; }
            set {
                _showTransactionControl = value;
                NotifyPropertyChanged("ShowTransactionControl");
            }
        }

        
        public MainViewModel() {
            TransactionButtonCommand = new ButtonCommands(ChangeTransactionVisibility);//Changes ChangeTransactionVisibility to true
        }

        public void addNewTarget(Target newTarget) {
            //adds a new item to the list
            DataContextHelper.AddRecord(newTarget);
        }

        private void ChangeTransactionVisibility() {
            ShowTransactionControl = true;
        }
    }
}
