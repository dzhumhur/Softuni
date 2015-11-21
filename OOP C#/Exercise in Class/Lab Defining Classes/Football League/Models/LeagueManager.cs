namespace Football_League.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();

            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;

                default:
                    break;
            }
        }

        private static void AddTeam(string name, string nickName, DateTime dateFounded)
        {
            Team team = new Team(name, nickName, dateFounded);
            League.AddTeam(team);
        }

        private static void AddMatch(int id, string homeTeamName, string awayTeamName, int homeTeamGoals, int awayTeamGoals)
        {
            Team homeTeam = League.Teams.FirstOrDefault(t => t.Name.Equals(homeTeamName));
            Team awayTeam = League.Teams.FirstOrDefault(t => t.Name.Equals(awayTeamName));
            Score matchScore = new Score(homeTeamGoals, awayTeamGoals); 

            Match match = new Match(id, homeTeam, awayTeam, matchScore);
            League.AddMatch(match);
        }

        private static void AddPlayerToTeam(string playerFirstName, string playerLastName, DateTime dateOfBirth, decimal salary, string teamName)
        {
            Team team = League.Teams.FirstOrDefault(t => t.Name.Equals(teamName));
            Player player = new Player(playerFirstName, playerLastName, dateOfBirth, salary, team);
            team.AddPlayer(player);
        }
    }
}
