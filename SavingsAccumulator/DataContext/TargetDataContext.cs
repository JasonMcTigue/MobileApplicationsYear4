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
        public DbSet<Target> Targets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
