using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesModels
{
    using System.ComponentModel.DataAnnotations;

    public class Movies
    {
        private ICollection<Users> users;
        private ICollection<Ratings> ratings; 

        public Movies()
        {
            this.users = new HashSet<Users>();
            this.ratings = new HashSet<Ratings>();
        }
        public int Id { get; set; }

        [Required]
        public string Isbn { get; set; }

        [StringLength(100), MinLength(2)]
        public string Title { get; set; }

        public AgeRestriction AgeRestriction { get; set; }

        public ICollection<Users> Users {
            get { return this.users; }
            set { this.users = value; }
        }

        public virtual ICollection<Ratings> Ratingses {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
    }
}
