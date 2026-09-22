using Microsoft.EntityFrameworkCore;

public class PaymentDbContext : DbContext
{
    public PaymentDbContext(DbContextOptions<PaymentDbContext> options)
        : base(options) { }

    public DbSet<Transaction> Transactions => Set<Transaction>();
}

//The DbContext creates a connection between the Transaction objects 
//and the Transactions database, while using an Entity Framework to operate on Transactions