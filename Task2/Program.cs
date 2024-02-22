using Task2;

var user1 = new User();
user1.FirstName = "Salmon";
user1.LastName = "Alimov";
System.Console.WriteLine("Write password and your username \n\nYour Password and User Name shoud be the same:");
System.Console.Write("Paste your password: ");
user1.Password = Console.ReadLine();
System.Console.Write("Write User Name: ");
user1.UserName = Console.ReadLine();
System.Console.WriteLine();
user1.Login();
System.Console.WriteLine(user1.GetFullInfo());