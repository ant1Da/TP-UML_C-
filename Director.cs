namespace TP_UML_C__GIT;

class Director
{
    public string FirstName;
    public string LastName;
    public string Country;
    public string getFirstName() { return FirstName; }
    public void setFirstName(string firstName) { FirstName = firstName; }
    public string getLastName() { return LastName; }
    public void setLastName(string lastName) { LastName = lastName; }
    public string getCountry() { return Country; }
    public void setCountry(string country) { Country = country; }
    public void DisplayDirector()
    {
        Console.WriteLine($"Nom : {this.getFirstName()} {this.getLastName()} | Pays : {this.getCountry()}");
    }
}