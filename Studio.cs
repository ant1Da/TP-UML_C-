class Studio
{
    public string Name;
    public string City;
    public string getName() { return Name; }
    public void setName(string name) { Name = name; }
    public string getCity() { return City; }
    public void setCity(string city) { City = city; }
    public void DisplayStudio()
    {
        Console.WriteLine($"Studio : {this.getName()} | Ville : {this.getCity()}\n");
    }
}