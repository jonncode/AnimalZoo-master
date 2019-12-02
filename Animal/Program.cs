using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal kurre = new Cat("Kurre", 6);
            Animal vilma = new Dog("Kurre", 3);

            kurre.IntroduceYourself();
            vilma.IntroduceYourself();

            Animal.SetYear(2013);

            kurre.IntroduceYourself();
            vilma.IntroduceYourself();
            Console.ReadKey();
        }
    }
}
