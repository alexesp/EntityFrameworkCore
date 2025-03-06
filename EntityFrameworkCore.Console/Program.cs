using EntityFrameworkCore.Data;
using EntityFrameworkCore.Data.ScaffoldModels;
using Microsoft.EntityFrameworkCore;

using var context = new FootballLeageDbContext();

await context.Database.MigrateAsync();

//GetAllTeams();


//var teamOne = await context.Teams.FirstAsync();
//var teamOne = await context.Teams.FirstOrDefaultAsync();

//var teamTwo = await context.Teams.FirstAsync(team => team.TeamId == 1);
//var teamTwo = await context.Teams.FirstOrDefaultAsync(team => team.TeamId == 1);

//var teamThree = await context.Teams.SingleAsync();
//var teamThree = await context.Teams.SingleAsync(team => team.TeamId == 2);
//var teamThree = await context.Teams.SingleOrDefaultAsync(team => team.TeamId == 2);

//void GetAllTeams()
//{
//    //LINQ
//    var teams = context.Teams.ToList();

//    foreach (var item in teams)
//    {
//        Console.WriteLine(item.Name);
//    }

//}

//await GetFilteredTeams();

//async Task GetFilteredTeams()
//{
//    var desiredTeam =  Console.ReadLine();
//    var teamsFiltered = await context.Teams.Where(q => q.Name == desiredTeam).ToListAsync();
//}

//var minTeams = await context.Teams.MinAsync(q => q.TeamId);
//var maxTeams = await context.Teams.MaxAsync(q => q.TeamId);

//var groupedTeams = context.Teams.GroupBy(q => q.CreateDate.Date);

//var orderedTeams = await context.Teams.OrderBy(q => q.Name).ToListAsync();
//var orderedTeams = await context.Teams.OrderByDescending(q => q.Name).ToListAsync();

//var teams = await context.Teams
//    .Select(q => q.Name)
//    .ToListAsync();

//var teams = await context.Teams
//    .Select(q => new { q.Name, q.CreateDate })
//    .ToListAsync();

//var teamsAsQueryable = context.Teams.AsQueryable();

///##########  INSERTING DATA  ###########################################

//var newCoach = new Coach
//{
//    Id = 5,
//    Name = "Jose Mourinho",
//    CreateDate = DateTime.Now,
//};
//await context.Coaches.AddAsync(newCoach);
//await context.SaveChangesAsync();
//context.Update(newCoach);


//var coach = await context.Coaches.FindAsync(1);

//context.Remove(coach);
//context.Entry(coach).State = EntityState.Detached;
//await context.SaveChangesAsync();




