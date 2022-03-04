using System;

namespace MovieDatabaseLab
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string repeat = "y";


            List<Movie> movieList = new List<Movie>
            {
                new Movie("Starwars", "scifi"),
                new Movie("The Matrix", "scifi"),
                new Movie("Inception", "scifi"),
                new Movie("Scream", "horror"),
                new Movie("Saw", "horror"),
                new Movie("Doctor Sleep", "horror"),
                new Movie("Knives Out", "drama"),
                new Movie("The Wolf of Wallstreet", "drama"),
                new Movie("Finding Nemo", "animated"),
                new Movie("Cars", "Animated")

            };


            Console.WriteLine("Welcome to the movie list application! ");
            Console.WriteLine("There are 10 movies in this list.");


            do
            {

                Console.WriteLine("Please enter a category of movie");
                var userCategory = Console.ReadLine().ToLower();

                List<Movie> selectedList = movieList.Where(x => x.GetCategory() == userCategory).ToList();
                foreach(Movie movie in selectedList)
                {
                    Console.WriteLine(movie.GetTitle());
                }

                //*********************************************************************
                //    if (userCategory.Contains("scifi"))
                //    {
                //        var scifiMovies = movieList.Where(x => x.Category == "scifi").ToList();
                //        foreach (Movie x in scifiMovies)
                //        {
                //            Console.WriteLine(x.Title);
                //        }
                //    }
                //    else if (userCategory.Contains("horror"))
                //    {
                //        var horrorMovies = movieList.Where(x => x.Category == "horror").ToList();
                //        foreach (Movie x in horrorMovies)
                //        {
                //            Console.WriteLine(x.Title);
                //        }
                //    }
                //    else if (userCategory.Contains("drama"))
                //    {
                //        var dramaMovies = movieList.Where(x => x.Category == "drama").ToList();
                //        foreach (Movie x in dramaMovies)
                //        {
                //            Console.WriteLine(x.Title);
                //        }
                //    }
                //    else if (userCategory.Contains("animated"))
                //    {
                //        var animatedMovies = movieList.Where(x => x.Category == "animated").ToList();
                //        foreach (Movie x in animatedMovies)
                //        {
                //            Console.WriteLine(x.Title);
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("that is not a movie genre in our application. Please enter scifi, horror, drama, or animated");
                //        Console.WriteLine();
                //        continue;
                //    }
                //************************************************************************************************************
                







                Console.WriteLine("Would you like to continue? (y/n)");
                repeat = Console.ReadLine().ToLower();

            }
            while (repeat == "y");

            Console.WriteLine("Goodbye!");

        }

    }

}
