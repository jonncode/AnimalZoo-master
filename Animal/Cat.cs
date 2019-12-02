using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name, int age)
        {
            base.name = name;
            species = SPECIES.CAT;
            canFly = false;
            SetAge(age);
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + name + " och är " + GetAge() + " år");
        }

    }

}
