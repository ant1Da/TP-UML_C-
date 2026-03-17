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

        // exercice 4
        Movie film2 = new Movie();
        film2.Title = "Titanic";
        film2.Duration = 195;
        film2.Director = director1;

        Director director2 = new Director();
        director2.FirstName = "Christopher";
        director2.LastName = "Nolan";
        director2.Country = "UK";
        Movie film3 = new Movie();
        film3.Title = "Inception";
        film3.Duration = 148;
        film3.Director = director2;
        Playlist playlist1 = new Playlist();
        playlist1.Name = "My Favorite Movies";
        playlist1.Movies = new List<Movie>();
        playlist1.AddMovie(film1);
        playlist1.AddMovie(film2);
        playlist1.AddMovie(film3);
        playlist1.DisplayPlaylist();
    }
}
