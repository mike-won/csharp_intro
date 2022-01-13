using System;
namespace intro_to_csharp
{
    public class Movie
    {
        // Step 1: Restrict access "public" modifier with "private,'
        // meaning only code within the class can access the attribute
        // Step 2: Define properties of getter/setter, allowing outside code to access/set rating
        // Step 3: Adjust reference under class attribute definition
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            // Step 3 executed below
            Rating = aRating;

        }

        // Properties define getters and setters
        // Name getter/setter same as attribute but capitalize letter
        public string Rating
        {
            get
            {
                return rating;

            }

            //Can define rules for setter (limit range of acceptable values)
            set {

                if ((value == "G") || (value == "PG") || (value == "PG-13") || (value == "R") || (value == "NR"))
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }

    public class Song
    {
        public string title;
        public string artist;
        public int duration;
        // For this exercise, "songCount" displays how many new songs were created
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {

            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;

        }

        public int GetSongCount()
        {
            return songCount;
        }
    }

    public class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }

    class chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad.");
        }

        public void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ Ribs.");
        }
    }

    // Italian chef can do all the things a chef can do, but more
    // Have the "ItalianChef" class inherit attributes from the "chef" class
    class ItalianChef : chef
    {
       
    }

}
