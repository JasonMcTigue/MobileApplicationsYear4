using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccumulator.Model
{
    [Table("Target")] //Name of the table in the database
    public class Target
    {
        [Key]//sets Id as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TargetId { get; set; }// Primary key and  identity column so it will auto incement by itself
        public string Name { get; set; }
        public decimal SavingTarget { get; set; } //is a decimal to allow user to in put cents.
        public decimal CurrentBalance { get; set; }//keeps track of the current balance

        public string Notes { get; set; }

        public DateTime Date { get; set; }
        
        public List<Transaction> Transactions { get; set; } //traget can have more then one list
    }
}
