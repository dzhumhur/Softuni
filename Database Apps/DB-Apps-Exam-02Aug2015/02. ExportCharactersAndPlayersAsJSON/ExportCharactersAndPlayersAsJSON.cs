using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExportCharactersAndPlayersAsJSON
{
    using System.IO;
    using System.Runtime.InteropServices;
    using _01.EntityFrameworkMapping;
    using System.Web.Script.Serialization;

    class ExportCharactersAndPlayersAsJSON
    {
        static void Main(string[] args)
        {
            var context = new DiabloEntities();
            var charsPlayers = context.Characters
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    name = c.Name,
                    playedBy = c.UsersGames
                    .Select(u => u.User.Username).ToList()
                }).ToList();

            //var jsSerializer = new JavaScriptSerializer();
            //var charactersWithPlayers = jsSerializer.Serialize(charsPlayers);
            //Console.WriteLine(charactersWithPlayers);

            var jsSerializer = new JavaScriptSerializer();
            var characterWithPlayersJSON = jsSerializer.Serialize(charsPlayers);
            StreamWriter file =
                new StreamWriter(
                    @"E:\DISK D\Softuni-Projects\Modul Back-End\DB Apps July 2015\Exams\DB-Apps-Exam-02Aug2015\02. ExportCharactersAndPlayersAsJSON\bin\Debug\characters.json");
            file.WriteLine(characterWithPlayersJSON);
            file.Close();

            
           
        }
    }
}
