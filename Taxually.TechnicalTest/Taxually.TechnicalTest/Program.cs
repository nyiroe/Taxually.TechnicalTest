using Taxually.Adapter.Queue;
using Taxually.Adapter.UK;
using Taxually.Core.Ports.Inbound;
using Taxually.Core.Ports.Outbound;
using Taxually.Core.Services;
using Taxually.Core.Services.VatRegistrationWorkers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddUkVatHttpClient();
builder.Services.AddScoped<IQueueService, QueueService>();
builder.Services.AddScoped<IVatRegistrationWorkerFactory, VatRegistrationWorkerFactory>();
builder.Services.AddScoped<IVatService, VatService>();
builder.Services.AddScoped<UkVatRegistrationWorker>().AddScoped<IVatRegistrationWorker, UkVatRegistrationWorker>(s => s.GetService<UkVatRegistrationWorker>()!);
builder.Services.AddScoped<DeVatRegistrationWorker>().AddScoped<IVatRegistrationWorker, DeVatRegistrationWorker>(s => s.GetService<DeVatRegistrationWorker>()!);
builder.Services.AddScoped<FrVatRegistrationWorker>().AddScoped<IVatRegistrationWorker, FrVatRegistrationWorker>(s => s.GetService<FrVatRegistrationWorker>()!);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
