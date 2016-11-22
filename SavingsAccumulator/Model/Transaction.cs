using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsAccumulator.Model
{
    //used to key track off all tranaction(date and time)
    class Transaction
    {

        [Key]//sets Id as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }// Primary key and  identity column so it will auto incement by itself
        public DateTime Date { get; set; }
        public decimal Amount { get; set; } //is a decimal to allow user to in put cents.
        public string TargetId { get; set; } //forign key 

        [ForeignKey("TargetId")]
        public Target Target { get; set; } // assigns target object to the target it is assigned with
    }
}
