namespace TP_UML_C__GIT;

class Movie
{
    private string title;
    private int duration;
    private Director director;
    public string Title
    {
        get {return title;}
        set {title = value;}
    }
    public int Duration
    {
        get {return duration;}
        set {duration = value;}
    }
    public Director Director
    {
        get {return director;}
        set {director = value;}
    }
    public void DisplayMovie()
    {
        Console.WriteLine($"Titre : {Title} | Durée : {Duration}");
        Director.DisplayDirector();
    }
}