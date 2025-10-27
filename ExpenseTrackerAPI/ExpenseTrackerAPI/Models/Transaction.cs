using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerApi.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Category { get; set; }

        public bool IsExpense { get; set; }
    }
}
