namespace TP_UML_C__GIT;

class Program
{
    static void Main(string[] args)
    {
        Movie film1 = new Movie();
        film1.setTitle("Avatar");
        film1.setDuration(149);

        Director Director1 = new Director();
        Director1.setFirstName("James");
        Director1.setLastName("Cameron");
        Director1.setCountry("Canada");
        Director1.DisplayDirector();
        film1.setDirector(Director1);

        // exercice 4
        Movie film2 = new Movie();
        film2.setTitle("Titanic");
        film2.setDuration(195);
        film2.setDirector(Director1);

        Director Director2 = new Director();
        Director2.setFirstName("Christopher");
        Director2.setLastName("Nolan");
        Director2.setCountry("UK");
        Movie film3 = new Movie();
        film3.setTitle("Inception");
        film3.setDuration(148);
        film3.setDirector(Director2);
        Playlist playlist1 = new Playlist();
        playlist1.setName("My Favorite Movies");
        playlist1.setMovies(new List<Movie>());
        playlist1.addMovie(film1);
        playlist1.addMovie(film2);
        playlist1.addMovie(film3);

        // exercice 5
        Studio studio1 = new Studio();
        studio1.setName("20th Century Fox");
        studio1.setCity("Los Angeles");
        film1.setStudio(studio1);
        Studio studio2 = new Studio();
        studio2.setName("Warner Bros");
        studio2.setCity("Burbank");
        film2.setStudio(studio1);
        film3.setStudio(studio2);
        playlist1.DisplayPlaylist();
        // exercice 6
    }
}