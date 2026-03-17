using TP_UML_C__GIT;

class Playlist
{
    public string Name;
    public List<Movie> Movies;
    public string getName() { return Name; }
    public void setName(string name) { Name = name; }
    public List<Movie> getMovies() { return Movies; }
    public void setMovies(List<Movie> movies) { Movies = movies; }
    public void addMovie(Movie movie) { Movies.Add(movie); }
    public void DisplayPlaylist()
    {
        Console.WriteLine($"Playlist : {Name}");
        foreach (Movie movie in Movies)
        {
            movie.DisplayMovie();
        }
    }
}