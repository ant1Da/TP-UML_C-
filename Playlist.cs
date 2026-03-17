using TP_UML_C__GIT;

class Playlist
{
    private string name;
    private List<Movie> movies;
    public string Name
    {
        get {return name;}
        set {name = value;}
    }
    public List<Movie> Movies
    {
        get {return movies;}
        set {movies = value;}
    }
    public void DisplayPlaylist()
    {
        Console.WriteLine($"Playlist : {Name}");
        foreach (Movie movie in Movies)
        {
            movie.DisplayMovie();
        }
    }
    public void AddMovie(Movie movie)
    {
        this.Movies.Add(movie);
    }
}