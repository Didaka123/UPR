using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPR
{
    internal class Movie
    {
        private int budget;
        private int boxOffice;
        private int usersVoted;
        private int sumRating;

        public string Title { get; set; }
        public int Year { get; set; }
        public List<Person> Actors { get; set; }

        public double Rating
        {
            get
            {
                if (usersVoted == 0)
                {
                    return 0;
                }
                return (double)sumRating / usersVoted;
            }
        }

        public Movie(string title, int year,  int budget)
        {
            Title = title;
            Year = year;
            this.budget = budget;

            Actors = new List<Person>();

            boxOffice = 0;
            usersVoted = 0;
            sumRating = 0;
        }

        public void AddActors(Person actors)
        {
            Actors.Add(actors);
        }


        public void AddVote(int rating)
        {
            if (rating >= 1 && rating <= 10)
            {
                usersVoted++;
                sumRating += rating;

            }
            else
            {
                Console.WriteLine("Оценката може да бъде между 1 и 10.Гласът");
            }
                usersVoted++;
                sumRating += rating;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rating: {Rating:F2}");
            Console.WriteLine("Actors:");

            foreach (Person actor in Actors)
            {
                Console.WriteLine($"--- {actor.Name} {actor.Family} {actor.Age}");
            }
        }
    }
}
