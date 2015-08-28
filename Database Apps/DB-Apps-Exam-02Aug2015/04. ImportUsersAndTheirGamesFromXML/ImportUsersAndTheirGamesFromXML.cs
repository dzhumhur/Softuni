using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ImportUsersAndTheirGamesFromXML
{
    using System.Xml.Linq;
    using System.Xml.XPath;
    using _01.EntityFrameworkMapping;

    class ImportUsersAndTheirGamesFromXML
    {
        static void Main()
        {
            var context = new DiabloEntities();
            var xmlDoc = XDocument.Load(@"..\..\..\users-and-games.xml");
            var allUsers = xmlDoc.XPathSelectElements("users/user");

            foreach (var xElement in allUsers)
            {
                string firstName = null;
                if (xElement.Attribute("first-name") != null)
                {
                    firstName = xElement.Attribute("first-name").Value;
                }

                string lastName = null;
                if (xElement.Attribute("last-name") != null)
                {
                    lastName = xElement.Attribute("last-name").Value;
                }

                string email = null;
                if (xElement.Attribute("email") != null)
                {
                    email = xElement.Attribute("email").Value;
                }

                string username = xElement.Attribute("username").Value;
                string ip = xElement.Attribute("ip-address").Value;
                DateTime registeredOn = DateTime.Parse(xElement.Attribute("registration-date").Value);
                bool isDeleted = xElement.Attribute("is-deleted").Value.Equals("1");

                var dbUser = context.Users.FirstOrDefault(u => u.Username == username);
                if (dbUser == null)
                {
                    var newUser = new User()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Email = email,
                        Username = username,
                        IpAddress = ip,
                        RegistrationDate = registeredOn,
                        IsDeleted = isDeleted
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();
                    Console.WriteLine("Successfully added user {0}", username);

                    var userGames = xElement.XPathSelectElements("games/game");
                    foreach (var userGame in userGames)
                    {
                        var gameName = userGame.Element("game-name").Value;
                        var character = userGame.Element("character");
                        var charName = character.Attribute("name").Value;
                        var cash = Decimal.Parse(character.Attribute("cash").Value);
                        var level = int.Parse(character.Attribute("level").Value);
                        DateTime joinedOn = DateTime.Parse(userGame.Element("joined-on").Value);

                        var addUserToGame = new UsersGame()
                        {
                            GameId = context.Games.FirstOrDefault(g => g.Name.Equals(gameName)).Id,
                            UserId = context.Users.FirstOrDefault(u => u.Username.Equals(username)).Id,
                            CharacterId = context.Characters.FirstOrDefault(c => c.Name.Equals(charName)).Id,
                            Level = level,
                            JoinedOn = joinedOn,
                            Cash = cash
                        };
                        context.UsersGames.Add(addUserToGame);
                        context.SaveChanges();
                        Console.WriteLine("User {0} successfully added to game {1}", username, gameName);
                    }
                }
                else
                {
                    Console.WriteLine("User {0} already exists", username);
                }
            }
        }
    }
}
