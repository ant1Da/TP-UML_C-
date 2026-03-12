namespace TP_UML_C__GIT;

class Movie
{
    private string title;
    private int duration;
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
    public void Display()
    {
        Console.WriteLine($"Titre : {this.Title} | Durée : {this.Duration}");
    }
}