using System.Net;
using System.Net.Mime;
using System.Text.Json;
using Asp.Versioning;
using Chilling.Goods.Api.Config;
using Chilling.Goods.Api.Data.Models;
using Chilling.Platform.Redis.Extensions;
using Chilling.Platform.Redis.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseKestrel(options => options.AddServerHeader = false);
builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();

builder.Services.AddRedisCache(builder.Configuration);

// builder.Services.AddApiVersioning(options =>
// {
//     options.DefaultApiVersion = new ApiVersion(1, 0);
//     options.ReportApiVersions = true;
//     options.AssumeDefaultVersionWhenUnspecified = true;
//     options.ApiVersionReader = new HeaderApiVersionReader("api-version");
// });

builder.Services.AddDbContext<GoodsDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DataAccessPostgreSqlProvider"))
);

// builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapControllers();
app.UseExceptionHandler((options) =>
{
    options.Run(async context =>
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = MediaTypeNames.Application.Json;
        var ex = context.Features.Get<IExceptionHandlerFeature>();
        if (ex != null)
        {
            var err = new ExceptionVm()
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = ex.Error.Message
            };
            var respose = JsonSerializer.Serialize(err);
            await context.Response.WriteAsync(respose).ConfigureAwait(false);
        }
    });
});
// app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI();

app.Run();