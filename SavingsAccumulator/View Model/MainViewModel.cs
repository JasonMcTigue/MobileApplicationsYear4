﻿using SavingsAccumulator.ButtonCommand;
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

        private int _targetId;
        
        public List<Target> TargetList {
            get { return DataContextHelper.GetTable<Target>(); }
        }

        //This class is needed to show the transaction control
        private bool _showTransactionControl = false;//set to false so the BoolVisibilityConverter will start as false when program is started..eg update page is collapsed
        public bool ShowTransactionControl {
            get { return _showTransactionControl; }
            set {
                _showTransactionControl = value;
                NotifyPropertyChanged("ShowTransactionControl");
            }
        }

        public int TargetId {
            get { return _targetId; }
            set {
                _targetId = value;
                NotifyPropertyChanged("TargetId");
            }
        }

        public bool ShowTargetControl { get; private set; }


        public ButtonCommands TransactionButtonCommand { get; set; }
        public ButtonCommands TargetButtonCommand { get; set; }
        // public ButtonCommands EditButtonCommand { get; set; }//this binds the buttons 
        public ButtonCommands DeleteButtonCommand { get; set; }

        public event EventHandler OnDeleteFinished;

       

        public MainViewModel() {
           TransactionButtonCommand = new ButtonCommands(ChangeTransactionVisibility);//Changes ChangeTransactionVisibility to true
           TargetButtonCommand = new ButtonCommands(ChangeTargetVisibility);//changes ChangeTargetVisibility to true so this page is displayed
           //EditButtonCommand = new ButtonCommands(EditTarget);
           DeleteButtonCommand = new ButtonCommands(DeleteTarget);
        }

        public async void addNewTarget(Target newTarget)
        {
            //adds a new item to the list
            await DataContextHelper.AddRecord(newTarget);
        }

        private void ChangeTransactionVisibility(object parameter) {

            var target = parameter as Target;
            TargetId = target.TargetId;

            ShowTransactionControl = true;//when add button is pressed this method is activated
        }

        private void ChangeTargetVisibility(object parameter) {

           
            ShowTargetControl = true;//makes the main page visible on start up
        }

        /*  private void EditTarget(object parameter) {
              var target = parameter as Target;
              TargetId = target.TargetId;

              this.TargetAction = TargetAction.Update;

              ShowTargetControl = true;
          }
          */

        private async void DeleteTarget(object parameter) {
            var target = parameter as Target;
            await DataContextHelper.DeleteTarget<Target>(target);//Removes record
            FireOnDeleteFinished();
        }

        private void FireOnDeleteFinished()
        {
            if (OnDeleteFinished != null)
                OnDeleteFinished(null, null);
        }
    }
}
