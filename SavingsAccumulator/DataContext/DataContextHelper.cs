using SavingsAccumulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccumulator.DataContext
{
    //static class to refer to for adding stuff.
    public static class DataContextHelper
    {
        public async void AddTarget(Target newTarget) {

            using (var db = new TargetDataContext()) {
                db.Targets.Add(newTarget); //adds a new target to the database
                await db.SaveChangesAsync();
            }
        }

        public async void AddTransation(Target newTransaction)
        {

            using (var db = new TargetDataContext())
            {
                db.Targets.Add(newTransaction); //adds a new target to the database
                await db.SaveChangesAsync();
            }
        }

       

    }
}
