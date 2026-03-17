class Studio
{
    private string name { get; set; }
    private string city { get; set; }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public void DisplayStudio()
    {
        Console.WriteLine($"Studio : {this.Name} | Ville : {this.City}\n");
    }
}