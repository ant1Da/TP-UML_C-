namespace TP_UML_C__GIT;

class Movie
{
    public string Title;
    public int Duration;
    public Director Director;
    public Studio Studio;
    public string getTitle() { return Title; }
    public void setTitle(string title) { Title = title; }
    public int getDuration() { return Duration; }
    public void setDuration(int duration) { Duration = duration; }
    public Director getDirector() { return Director; }
    public void setDirector(Director director) { Director = director; }
    public Studio getStudio() { return Studio; }
    public void setStudio(Studio studio) { Studio = studio; }
    public void DisplayMovie()
    {
        Console.WriteLine($"Titre : {this.getTitle()} | Durée : {this.getDuration()}");
        Director.DisplayDirector();
        Studio.DisplayStudio();
    }
}