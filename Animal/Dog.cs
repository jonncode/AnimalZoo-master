using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name, int age)
        {
            base.name = name;
            species = SPECIES.DOG;
            canFly = false;
            SetAge(age);

        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter " + name + " och är " + GetAge() + " år");
        }


    }

}
