using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2605lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            print(4);
            Console.WriteLine("============");


            printb(DaysOfTheWeek.Saturday);



            Console.WriteLine("============");


            Enum.GetNames(typeof(DaysOfTheWeek)).ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine("============");
            DaysOfTheWeek[] days = (DaysOfTheWeek[])Enum.GetValues(typeof(DaysOfTheWeek));
        }

        public static void printb(DaysOfTheWeek day)
        {
            Console.WriteLine((int)day);


            switch (day)
            {
                case DaysOfTheWeek.Sunday:
                    Console.WriteLine("Rishon");
                    break;
                case DaysOfTheWeek.Monday:
                    Console.WriteLine("Sheni");
                    break;
                case DaysOfTheWeek.Tuesday:
                    Console.WriteLine("Slishi");
                    break;
                case DaysOfTheWeek.Wednesday:
                    Console.WriteLine("Revii");
                    break;
                case DaysOfTheWeek.Thursday:
                    Console.WriteLine("Hamishi");
                    break;
                case DaysOfTheWeek.Friday:
                    Console.WriteLine("Shishi");
                    break;
                case DaysOfTheWeek.Saturday:
                    Console.WriteLine("Shabat");
                    break;
                default:
                    break;
            }
        }

        public static void print(int day)
        {
            Enum.TryParse($"{day}", out DaysOfTheWeek result);
            Console.WriteLine(result);
        }
    }
}
