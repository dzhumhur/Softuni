using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesModels
{
    using System.ComponentModel.DataAnnotations;

    public class Users
    {
        private ICollection<Movies> movies;
        private ICollection<Ratings> ratings; 

        public Users()
        {
            this.movies = new HashSet<Movies>();
            this.ratings = new HashSet<Ratings>();
        }
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Username { get; set; }

        public string Email { get; set; }

        public int? Age { get; set; }

        public int CountryId { get; set; }
        public virtual Countries Country { get; set; }

        public virtual ICollection<Movies> Movies {
            get { return this.movies; }
            set { this.movies = value; }
        }

        public virtual ICollection<Ratings> Ratingses {
            get { return this.ratings; }
            set { this.ratings = value; }
        }
    }
}
