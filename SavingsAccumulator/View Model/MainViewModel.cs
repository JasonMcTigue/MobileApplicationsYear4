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
        //OC Noets when the list has changed
        private ObservableCollection<Target> _targetList;

        public ObservableCollection<Target> TargetList {
            get { return _targetList; }
            set {
                _targetList = value;
                NotifyPropertyChanged("TargetList");
            }
        }

        public MainViewModel() {
            _targetList = new ObservableCollection<Target>();
        }

        public void addNewTarget(Target newTarget) {
            //adds a new item to the list
            TargetList.Add(newTarget);
        }
    }
}
