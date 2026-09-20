    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mark", "Hamill", 26);
            Person person2 = new Person("Carrie", "Fisher", 21);
            Person person3 = new Person("Harrison", "Ford", 35);
            Person person4 = new Person("Alec", "Guinness", 63);

            Movie movie = new Movie("A New Hope", 1977, 11000000);

            movie.AddActors(person1);
            movie.AddActors(person2);
            movie.AddActors(person3);
            movie.AddActors(person4);

            movie.AddVote(8);
            movie.AddVote(10);
            movie.AddVote(10);
            movie.AddVote(9);

            movie.ShowInfo();

        }
    }
}
