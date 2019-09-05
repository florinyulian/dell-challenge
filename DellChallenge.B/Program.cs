using System;

namespace DellChallenge.B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the classes and interface below, please constructor the proper hierarchy.
            // Feel free to refactor and restructure the classes/interface below.
            // (Hint: Not all species and Fly and/or Swim)
        }
    }



    public interface IEatAndDrink
    {
        void Eat();
        void Drink();
    }

    public interface IFly
    {
        void Fly();
    }

    public interface ISwim
    {
        void Swim();
    }

    public class Species
    {
        public virtual void GetSpecies()
        {
            Console.WriteLine($"Echo who am I?");
        }
    }

    public class Human : IEatAndDrink, ISwim, IFly
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

    public class Bird : IFly
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class Fish : ISwim
    {
        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}

