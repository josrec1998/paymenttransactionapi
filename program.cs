using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<PaymentDbContext>(options =>
    options.UseInMemoryDatabase("Payments"));

builder.Services.AddScoped<PaymentService>();

var app = builder.Build();

app.MapControllers();

app.Run();
//configures application builder to use controllers, registers paymentDbContext and PaymentService for 
// dependency injection then runs the application