using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private List<Animal> Animals = new List<Animal>();


        //TEST 1
        public void Enter(Animal animal)
        {
            Animals.Add(animal);
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine($"{animal.AnimalType} has entered the Emydex farm");
        }
     
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            //Console.WriteLine("There are no animals in the farm");

            foreach (var animal in Animals)
                animal.Talk();

        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var milk in Animals.Where(t => t is IMilkableAnimal).ToArray())
                ((IMilkableAnimal) milk).ProduceMilk();

        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}