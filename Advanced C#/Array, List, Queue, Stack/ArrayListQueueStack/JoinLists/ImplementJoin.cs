namespace JoinLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ImplementJoin
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            SortedSet<int> firstInputAsArray = new SortedSet<int>(firstInput
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            string secondInput = Console.ReadLine();
            SortedSet<int> secondInputAsArray = new SortedSet<int>(secondInput
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            SortedSet<int> result = new SortedSet<int>();

            foreach (var element in secondInputAsArray)
            {
                result.Add(element);
            }

            foreach (var element in firstInputAsArray)
            {
                result.Add(element);
            }

            
            result.ToList().ForEach(a => Console.Write(a + " "));
            Console.WriteLine();

        }
    }
}
