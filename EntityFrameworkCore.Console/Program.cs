using EntityFrameworkCore.Data;

var context = new FootballLeageDbContext();


//LINQ
var teams = context.Teams.ToList();

foreach(var item in teams)
{
    Console.WriteLine(item.Name);
}
