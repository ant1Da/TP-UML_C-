namespace TP_UML_C__GIT;

class Director
{
    private string firstName;
    private string lastName;
    private string country;
    public string FirstName
    {
        get {return firstName;}
        set {firstName = value;}
    }
    public string LastName
    {
        get {return lastName;}
        set {lastName = value;}
    }
    public string Country
    {
        get {return country;}
        set {country = value;}
    }
    public void DisplayDirector()
    {
        Console.WriteLine($"Nom : {FirstName} {LastName} | Pays : {Country}\n");
    }
}