using System;
namespace intro_to_csharp
{
    public class Movie
    {
        public string title;
        public string director;
        public string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;

        }
    }
}
