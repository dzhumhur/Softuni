namespace Football_League.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateTime = dateFounded;
            this.players = new List<Player>();
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new Exception("Invalid Team name");
                }

                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new Exception("Invalid Team name");
                }

                this.nickname = value;
            }
        }

        public DateTime DateTime
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year < 1850)
                {
                    throw new ArgumentOutOfRangeException("Date founded's year should be greater than 1850");
                }

                this.dateFounded = value;
            }
        }


        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team");
            }

            this.players.Add(player);
            Console.WriteLine("Successfully added Player {0} {1} to team {2}", player.FirstName, player.LastName, this.Name);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName &&
                                       p.LastName == player.LastName);
        }

        public override string ToString()
        {
            var result = string.Format(" {0}\n|{1}|\n {0}\n", 
                                       new string('-', this.Name.Length),
                                       this.Name);
            return result;
        }
    }
}
