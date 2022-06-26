using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePracticeTime
{
    internal class Examples
    {





        /* public static void Main(string[] args)
        {
            var numbers = new List<int>();

            while(true)
            {
                Console.Write("Enter a number (or quit to exit)");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            Console.WriteLine("Unique Numbers: ");
            foreach(var number in GetUniqueNumbers(numbers))
                Console.WriteLine(number);
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }
            return uniques; 
        
    }*/




     /*   public static void Main(string[] args)
            {
                Console.Write("Whats your name?");
                var name = Console.ReadLine();
                var reversed = ReverseName(name);
                Console.WriteLine("Reversed Name: " + ReverseName(name));
            }

            public static string ReverseName(string name)
            {
                var array = new char[name.Length];
                for (var i = name.Length; i > 0; i--)
                    array[name.Length - i] = name[i - 1];

                return new string(array);
            }*/

    }
}
