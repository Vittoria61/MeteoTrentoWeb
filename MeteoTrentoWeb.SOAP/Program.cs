using SoapCore;
using MeteoTrentoWeb.SOAP.BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddScoped<ISOAPService, SoapService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<ISOAPService>("/Service2.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();