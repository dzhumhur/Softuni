using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExportFinishedGamesAsXML
{
    using System.Xml.Linq;
    using _01.EntityFrameworkMapping;

    class ExportFinishedGamesAsXML
    {
        static void Main(string[] args)
        {
            var context = new DiabloEntities();
           
            var usersGames = context.Games
                .Where(g => g.IsFinished == true)
                .OrderBy(g => g.Name)
                .ThenBy(g => g.Duration)
                .Select(g => new
                {
                   gameName = g.Name,
                   gameDuration = g.Duration,
                   Users = g.UsersGames
                   .Select(u => new
                   {
                       Username = u.User.Username,
                       Ip = u.User.IpAddress
                   }).ToList()
                }).ToList();


            var xmlGames = new XElement("games");

            usersGames.ForEach(g =>
            {
                var xmlGame = new XElement("game");
                xmlGames.Add(xmlGame);
                xmlGame.Add(new XAttribute("name", g.gameName));
                if (g.gameDuration != null)
                {
                    xmlGame.Add(new XAttribute("duration", g.gameDuration));
                }
                var xmlUsers = new XElement("users");
                xmlGame.Add(xmlUsers);

                g.Users.ForEach(u =>
                {
                    var xmlUser = new XElement("user");
                    xmlUser.Add(new XAttribute("username", u.Username));
                    xmlUser.Add(new XAttribute("ip-address", u.Ip));
                    xmlUsers.Add(xmlUser);
                });
            });

            var xmlDoc = new XDocument(xmlGames);
            xmlDoc.Save("finished-games.xml");
            //Console.WriteLine(xmlDoc);


            //usersGames.ForEach(g =>
            //{
            //    Console.WriteLine("{0} : {1}", g.gameName, g.gameDuration);
            //    g.Users.ForEach(u =>
            //    {
            //        Console.WriteLine(u.Username + " " + u.Ip + ",");
            //    });
            //    Console.WriteLine();
            //});

        }
    }
}
