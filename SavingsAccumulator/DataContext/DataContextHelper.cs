using SavingsAccumulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SavingsAccumulator.DataContext
{
    //static class to refer to for adding stuff.
    public static class DataContextHelper
    {

        /*
        public static async void AddTarget(Target newTarget)
        {

            using (var db = new TargetDataContext())
            {
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
        */

        //generic method so both classes can share one method
        public static async void AddRecord<T>(T newRecord) where T: class
        {

            using (var db = new TargetDataContext())
            {
                db.Add<T>(newRecord); //adds a new target to the database
                await db.SaveChangesAsync();
            }
        }


/*
        internal static List<Target> GetTargets()
        {
            using (var db = new TargetDataContext())
            {
                return db.Targets.ToList();
            }
        }
        */

            //can get tragets and transactions from one method
        public static List<T> GetTable<T>() where T : class {
            using (var db = new TargetDataContext())
            {
                return db.Set<T>().ToList();//displays inputs on the screen
            }
        }

       
        public static async void UpdateTarget(Target updateTarget)
        {

            using (var db = new TargetDataContext())
            {
                var target = db.Targets.FirstOrDefault(x => x.TargetId == updateTarget.TargetId);
                if (target != null)
                {
                    //entity framwork keeps track of the target item so when the properties are saved the datacontext knows there has been a change.
                    target.Name = updateTarget.Name;//Updates the name after a change by the user
                    target.Notes = updateTarget.Notes;// Updates the notes after a change by the user
                    target.SavingTarget = updateTarget.SavingTarget;// Updates the saving target after a change by the user
                    await db.SaveChangesAsync();
                }


            }
        }

       /* public static List<Target> GetTargets()
        {
            using (var db = new TargetDataContext())
            {
                return db.Targets.ToList();
            }
        }*/
    }
}
