namespace _05.HTML_Dispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            ElementBuilder element = new ElementBuilder("div");
            element.AddAttribute("id", "page");
            element.AddAttribute("class", "big");
            element.AddContent("<p>Hello</p>");
            Console.WriteLine(element * 2);

            HTMLDispatcher.CreateImage("../../../Sottuni.jpeg", "QQWW3", "Softuni");
            Console.WriteLine();
            HTMLDispatcher.CreateURL("www.softuni.bg", "The best University", "SoftUni");
            Console.WriteLine();
            HTMLDispatcher.CreateInput("submit", "Submit", "Send");
        }
    }
}
