namespace TP_UML_C__GIT;

class Program
{
    static void Main(string[] args)
    {
        Movie film1 = new Movie();
        film1.Title = "Avatar";
        film1.Duration = 149;

        Director director1 = new Director();
        director1.FirstName = "James";
        director1.LastName = "Cameron";
        director1.Country = "USA";
        director1.DisplayDirector();
        film1.Director = director1;
        film1.DisplayMovie();
    }
}
