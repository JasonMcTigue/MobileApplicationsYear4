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
       public List<Target> TargetList {
            get { return DataContextHelper.GetTargets(); }
        }
      
        public MainViewModel() {
          
        }

        public void addNewTarget(Target newTarget) {
            //adds a new item to the list
            DataContextHelper.AddTarget(newTarget);
        }
    }
}
