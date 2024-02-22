namespace Task3;

public class Author
{
    string _name;
    int _age;
    string _nationality;

    public Author(){}
    public Author(string name,int age)
    {
        _name = name;
        _age = age;
    }
    public Author(string name,int age,string nationality)
    {
        _name = name;
        _age = age;
        _nationality = nationality;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    public string GetNationality()
    {
        return _nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"My name is {_name}. I am {_age} years old. I am from {_nationality}.");
    }
    public void CelebrateBirthday()
    {
        _age++;
        System.Console.WriteLine($"Happy Birthday !!! {_name}  {_age}");
    }
}
