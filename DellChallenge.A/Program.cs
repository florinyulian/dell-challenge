using System;

namespace DellChallenge.A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Because B inhersits from parent Class A, first <Console.WriteLine("A.A()");> will be executed (base class code runs first) 
            //Then <Console.WriteLine("B.B()");> will be executed
            //Last <Console.WriteLine("A.Age");> will be executed because in B class property Age has the set to 0,and A has a method for writing to Console
            new B();
            Console.ReadKey();
        }
    }

    class A
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                Console.WriteLine("A.Age");
            }
        }


        public A()
        {
            Console.WriteLine("A.A()");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B.B()");
            Age = 0;
        }
    }
}
