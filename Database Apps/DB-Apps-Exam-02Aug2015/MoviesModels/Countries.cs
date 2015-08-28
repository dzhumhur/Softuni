using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesModels
{
    using System.ComponentModel.DataAnnotations;

    public class Countries
    {
        private ICollection<Users> users;

        public Countries()
        {
            this.users = new HashSet<Users>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Users> Users {
            get { return this.users; }
            set { this.users = value; }
        }
    }
}
