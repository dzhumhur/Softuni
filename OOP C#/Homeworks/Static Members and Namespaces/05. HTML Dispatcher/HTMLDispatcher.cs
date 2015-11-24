namespace _05.HTML_Dispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class HTMLDispatcher
    {
        public static void CreateImage(string imgSource, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("source", imgSource);
            img.AddAttribute("alt", alt);
            img.AddAttribute("title", title);

            Console.WriteLine(img);
        }

        public static void CreateURL(string url, string title, string text)
        {
            ElementBuilder link = new ElementBuilder("a");
            link.AddAttribute("href", url);
            link.AddAttribute("title", title);
            link.AddContent(text);

            Console.WriteLine(link);
        }

        public static void CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);

            Console.WriteLine(input);
        }
    }
}
