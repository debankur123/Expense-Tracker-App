using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EXpense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int CategoryId { get; set; }
        // to define there is a foreign key concept associated with categoryId
        public Category Category { get; set; } 
        public int Amount { get; set; }
        [Column(TypeName ="nvarchar(150)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
