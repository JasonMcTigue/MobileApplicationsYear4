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
        public static async void AddTarget(Target newTarget) {

            using (var db = new TargetDataContext()) {
                db.Targets.Add(newTarget); //adds a new target to the database
                await db.SaveChangesAsync();
            }
        }

        public static async void AddTransation(Target newTransaction)
        {

            using (var db = new TargetDataContext())
            {
                db.Targets.Add(newTransaction); //adds a new target to the database
                await db.SaveChangesAsync();
            }
        }

        public static async void UpdateTarget(Target updateTarget)
        {

            using (var db = new TargetDataContext())
            {
                var target = db.Targets.FirstOrDefault(x => x.TargetId == updateTarget.TargetId);
                if (target != null) {
                    //entity framwork keeps track of the target item so when the properties are saved the datacontext knows there has been a change.
                    target.Name = updateTarget.Name;//Updates the name after a change by the user
                    target.Notes = updateTarget.Notes;// Updates the notes after a change by the user
                    target.SavingTarget = updateTarget.SavingTarget;// Updates the saving target after a change by the user
                    await db.SaveChangesAsync();
                }
            }
        }


    }
}
