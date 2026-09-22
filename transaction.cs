public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Merchant { get; set; } = "";
    public string Status { get; set; } = "Pending";
}

//This class represents a payment transaction stored in the database, with its different fields