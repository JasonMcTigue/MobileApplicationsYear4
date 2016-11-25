using Microsoft.EntityFrameworkCore;
using SavingsAccumulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SavingsAccumulator.DataContext
{
    //Ran Install-Package Microsoft.EntityFrameworkCore.SQLite -Pre to instal entity framwork with sqllite
    public class TargetDataContext : DbContext //DbContext corresponds to the database ,
                                               //DbContext object gets access to the tables and views.

    {
        //DbSet's get access tocreate, update, delete and modify the data in the table.
        //All entitie a DbSet inside a DbContext will be picked up by EF and added to the schema.
        public DbSet<Target> Targets { get; set; } 
        public DbSet<Transaction> Transactions { get; set; }

        //OnConfiguring allows you to specify the provider and its option
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=SavingsAccumulator2.db");
        }

    }
}
