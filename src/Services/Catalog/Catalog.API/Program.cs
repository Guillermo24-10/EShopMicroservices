using BuildingBlocks.Extensions;
using Catalog.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
builder.Services.AddCarterWithAssemblies(typeof(Program).Assembly);
builder.Services.AddMartenExtension(builder.Configuration);
builder.Services.AddValidatorExtension();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

//Configure the HTTP request pipeline
app.MapCarter();


app.Run();
