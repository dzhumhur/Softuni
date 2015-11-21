namespace Football_League
{
    using System;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FootballLeague
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("       --All Matches-- ");
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
            Console.WriteLine();
            
            Console.WriteLine(" --All Teams-- ");
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
                foreach (var player in team.Players)
                {
                    Console.WriteLine(player);
                }
            }
        }
    }
}
