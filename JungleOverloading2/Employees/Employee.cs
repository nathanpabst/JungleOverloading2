using System;
using System.Collections.Generic;
using System.Text;

namespace JungleOverloading2.Employees
{
    class Employee
    {
        //properties
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private List<string> Restaurants { get; } = new List<string> { "Texas Tom's", "Pizza Palace", "Midieval Times", "The Dumpster" };
        private Random rando = new Random();

        //Constructor with two parameters
        public Employee(string first, string last)
        {
            FirstName = first;
            LastName = last;

        }
        //Methods
        public void Eat()
        {
            var restaurant = Restaurants[rando.Next(0, Restaurants.Count)];
            Console.WriteLine($"{FirstName} is eating at {restaurant}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} ate {food} in the office.");
        }

        public void Eat(List<Employee> pals)
        {
            var resturant = Restaurants[rando.Next(0, Restaurants.Count)];
            var palList = new List<string>();
            foreach (var pal in palList)
            {
                palList.Add(pal.FirstName);
            }
            var palString = string.Join(",", palList);

            Console.WriteLine($"{FirstName} ate at {resturant} with {palString}");
        }

    }
}
