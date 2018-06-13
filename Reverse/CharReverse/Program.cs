using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharReverse
{
    class Program
    {

        static int number;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Write a number: ");
                    number = int.Parse(Console.ReadLine());

                    string check = number == Reverse() ? "This character is palindrom" : "This character isn't palindrom";
                    Console.WriteLine(check);

                }
                catch ( e)
                {
                    Console.WriteLine("Type of writing value must be a integer");
                }


            }

        }

        private static int Reverse()
        {
            string numbers = number.ToString();
            char[] charArray = numbers.ToCharArray();
            Array.Reverse(charArray);
            numbers = new string(charArray);
            return int.Parse(numbers);
        }
    }
}
