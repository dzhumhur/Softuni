namespace Football_League.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Match
    {
        private int id;
        private Team homeTeam;
        private Team awayTeam;
        private Score score;

        public Match(int id, Team homeTeam, Team awayTeam, Score score)
        {
            this.Id = id;
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
        }
        
        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Id cannot be negative or 0");
                }

                this.id = value;
            }
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set
            {
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set
            {
                if (value.Name.Equals(this.HomeTeam.Name))
                {
                    throw new Exception("Awayteam name should be different by hometeam name");
                }

                this.awayTeam = value;
            }
        }

        public Score Score { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                    ? this.HomeTeam 
                    : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public override string ToString()
        {
            var result = string.Format("{0}. {1} ({2} - {3}) {4}",
                                       this.Id,
                                       this.HomeTeam.Name,
                                       this.Score.HomeTeamGoals,
                                       this.Score.AwayTeamGoals,
                                       this.AwayTeam.Name
                                       );
            return result;
        }
    }
}
