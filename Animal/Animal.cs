    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD }

        public string name { get; set; }
        public SPECIES species { get; set; }
        public bool canFly { get; set; }
        private static int currentYear = 2019;
        private int birthYear;

/*        public Animal(string name, int age)
        {
            this.birthYear = Animal.currentYear - age;
        }
  */
    public int GetAge()
        {
            return Animal.currentYear - this.birthYear;
        }
        public void SetAge(int age)
        {
            birthYear = currentYear - age;
        }
        static public void SetYear(int year)
        {
            currentYear = year;
        }
        public virtual void IntroduceYourself()
        {
            Console.WriteLine("Morr.Jag är ett djur som heter "+name);
        }
        public void Print()
        {
            if (friend != null)
            {
                Console.WriteLine("Här är uppgifter om min kompis");

            }
        }
    }

}
