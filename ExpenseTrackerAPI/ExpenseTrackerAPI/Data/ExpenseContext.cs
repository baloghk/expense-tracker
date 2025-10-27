using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerApi.Data
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<ExpenseTrackerApi.Models.Transaction> Transactions { get; set; }
    }
}
