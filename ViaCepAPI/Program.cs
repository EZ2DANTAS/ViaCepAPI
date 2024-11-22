using Refit;
using ViaCepAPI.Integracao;
using ViaCepAPI.Integracao.Interfaces;
using ViaCepAPI.Integracao.Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c => 
{
    c.BaseAddress = new Uri("https://viacep.com.br");
});

builder.Services.AddScoped<IViaCepIntegracao, ViaCepIntegracao>();

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
