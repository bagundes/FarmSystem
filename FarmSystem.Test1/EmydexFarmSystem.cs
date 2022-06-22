using System;
using System.Collections.Generic;

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
            Console.WriteLine("There are no animals in the farm");
        }

        //TEST 3
        public void MilkAnimals()
        {
            Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
           Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}