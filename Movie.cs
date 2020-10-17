using System;
namespace StarterProject
{
    public class Movie
    {
        public string title; //Means these can be accessed by anyone 
        public string director;
        private string rating; //Means only code in the movie class can access this

        public Movie(string xtitle, string xdirector, string xrating)
        {
            title = xtitle;
            director = xdirector;
            Rating = xrating;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
            }
        }
    }
}
