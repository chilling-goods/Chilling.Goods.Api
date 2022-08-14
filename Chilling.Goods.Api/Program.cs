using System.Net.Mime;
using System.Reflection;
using Asp.Versioning;
using Chilling.Goods.Api;
using Chilling.Goods.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
builder.Services.AddHttpContextAccessor();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = new HeaderApiVersionReader("api-version");
});

var sqlConnectionString = builder.Configuration.GetConnectionString("DataAccessPostgreSqlProvider");
 
builder.Services.AddDbContext<GoodsDbContext>(options =>
    options.UseNpgsql(
        sqlConnectionString,
        b => b.MigrationsAssembly("Chilling.Goods.Api.Data")
    )
);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapApiEndpoints();

app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.Run();