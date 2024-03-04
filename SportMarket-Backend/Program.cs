using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using SportMarket_Backend.Data;
using SportMarket_Backend.Mappings;
using SportMarket_Backend.Repositories.Images;
using SportMarket_Backend.Repositories.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SportMarketDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SportMarketDBConnectionString")));

builder.Services.AddScoped<IProductRepository, SQLProductRepository>();
builder.Services.AddScoped<IImageRepository, LocalImageRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "Images")
        ),
    RequestPath = "/Images"
});

app.MapControllers();

app.Run();
