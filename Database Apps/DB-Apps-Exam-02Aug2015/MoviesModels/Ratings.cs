using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesModels
{
    using System.ComponentModel.DataAnnotations;

    public class Ratings
    {
        [Key]
        [Range(1,10)]
        public int Id { get; set; }

        public int Stars { get; set; }

        public int UsersId { get; set; }

        public virtual Users User { get; set; }

        public int MoviesId { get; set; }

        public virtual Movies Movieses { get; set; }


    }
}
