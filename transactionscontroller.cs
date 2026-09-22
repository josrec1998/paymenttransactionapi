using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/transactions")]
public class TransactionsController : ControllerBase
{
    private readonly PaymentService _service;

    public TransactionsController(PaymentService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Transaction>> Get(int id)
    {
        var transaction = await _service.GetTransaction(id);

        if (transaction == null)
            return NotFound();

        return Ok(transaction);
    }

    [HttpPost]
    public async Task<ActionResult<Transaction>> Create(Transaction transaction)
    {
        var created = await _service.CreateTransaction(transaction);

        return Ok(created);
    }
}

//Incoming json file with transaction data is then sent to PaymentService using HTTP Endpoints, GET retrieving it
// and post sending it