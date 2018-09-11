using System;
using System.Collections.Generic;
using JungleOverloading2.Employees;


namespace JungleOverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating Employee class
            var palOne = new Employee("Bob", "Lahblah");
            var palTwo = new Employee("Rachel", "Hunter");
            var palThree = new Employee("Frank", "Ley");
            var palFour = new Employee("Nicole", "Jones");

            var palOnesPals = new List<Employee> { palTwo, palThree, palFour };

            palOne.Eat();
            palTwo.Eat("fish");
            palOne.Eat(palOnesPals);
            Console.ReadLine();
        }
    }
}