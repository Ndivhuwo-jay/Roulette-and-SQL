using SQLite;
using WeKeepOnTrying.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    if (System.IO.File.Exists(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db"))
    {
        var db = new SQLiteConnection(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db");
        db.CreateTable<Spin_Table>();
        db.CreateTable<BetsTable>();
        db.Close();
    }
    else
    {
        var db = new SQLiteConnection(@"C:\Users\SBU\source\repos\WeKeepOnTrying\WeKeepOnTrying\Data\DataContext\RouletteDatabase.db");
        db.CreateTable<Spin_Table>();
        db.CreateTable<BetsTable>();

        db.Close();

    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
