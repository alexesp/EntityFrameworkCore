using EntityFrameworkCore.Data;
using Microsoft.EntityFrameworkCore;

using var context = new FootballLeageDbContext();



//GetAllTeams();


//var teamOne = await context.Teams.FirstAsync();
//var teamOne = await context.Teams.FirstOrDefaultAsync();

//var teamTwo = await context.Teams.FirstAsync(team => team.TeamId == 1);
//var teamTwo = await context.Teams.FirstOrDefaultAsync(team => team.TeamId == 1);

//var teamThree = await context.Teams.SingleAsync();
//var teamThree = await context.Teams.SingleAsync(team => team.TeamId == 2);
var teamThree = await context.Teams.SingleOrDefaultAsync(team => team.TeamId == 2);

//void GetAllTeams()
//{
//    //LINQ
//    var teams = context.Teams.ToList();

//    foreach (var item in teams)
//    {
//        Console.WriteLine(item.Name);
//    }

//}
