namespace Football_League.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            if (Teams.Any(t => t.Name.Equals(team.Name)))
            {
                throw new Exception("Team " + team.Name + " already exists");
            }

            teams.Add(team);
            Console.WriteLine("Successfully added Team {0}", team.Name);
        }

        public static void AddMatch(Match match)
        {
            if (Matches.Any(m => m.Id == match.Id))
            {
                throw new Exception("Match with Id: " + match.Id + " already exists");
            }

            matches.Add(match);
            Console.WriteLine("Successfully added Match with id: {0}", match.Id);
        }
    }
}
