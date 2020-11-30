using System;

namespace OOP
{

    class Program
    {
        static TeamKVN GetTeam()
        {
            TeamKVN team = new TeamKVN();
            team.name = "Алоха";
            team.commandStructure = "3 парней и 2 девушек";
            team.averageAge = 19;
            team.yearOfCreation = 2008;
            team.captainTeam = "Петров Петр";
            return team;
        }

        static void Print(TeamKVN team)
        {
            Console.WriteLine($"Название команды КВН :{team.name }");
            Console.WriteLine($"Команда состоит из :{team.commandStructure }");
            Console.WriteLine($"Средний возвраст команды :{ team.averageAge}");
            Console.WriteLine($"Год создания команды :{team.yearOfCreation }");
            Console.WriteLine($"Капитан команды :{ team.captainTeam}");
        }

        static void Main(string[] args)
        {
            var team = GetTeam();

            Print(team);
        }
    }
}
