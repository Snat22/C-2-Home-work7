namespace Task2;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; } 
    public string Password { get; set; }
    public bool IsLoggedIn;

    public void Login()
    {
        if (UserName == Password )
        {
            System.Console.WriteLine("Пользователь успешно зарегистрирован");
            IsLoggedIn = true;
        }else
        {
            System.Console.WriteLine("Ваш пароль или имя пользователя неверны");
        }
    }

    public void Logout()
    {
        IsLoggedIn = false;
    }

    public string GetFullInfo()
    {
        return $"{FirstName} {LastName} {IsLoggedIn}";
    }
}
