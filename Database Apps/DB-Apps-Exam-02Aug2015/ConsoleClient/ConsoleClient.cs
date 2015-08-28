using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    using MoviesData;
    using MoviesModels;

    class ConsoleClient
    {
        static void Main()
        {
            var context = new MoviesContext();
            var users = context.User.Count();
            Console.WriteLine(users);
        }
    }
}
