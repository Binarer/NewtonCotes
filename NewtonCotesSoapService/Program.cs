using NewtonCotesSoapService.App.Domain.Services.MathService;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<IMathService, MathService>();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSoapEndpoint<IMathService>("/MathService.asmx", new SoapEncoderOptions());

app.Run();