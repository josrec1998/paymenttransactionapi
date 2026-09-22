using Microsoft.EntityFrameworkCore;

public class PaymentService
{
    private readonly PaymentDbContext _db;

    public PaymentService(PaymentDbContext db)
    {
        _db = db;
    }

    public async Task<Transaction?> GetTransaction(int id)
    {
        return await _db.Transactions.FindAsync(id);
    }

    public async Task<Transaction> CreateTransaction(Transaction transaction)
    {
        _db.Transactions.Add(transaction);
        await _db.SaveChangesAsync();

        return transaction;
    }
} 
//Upon finding a transaction, this will then be added by using the EF Transaction