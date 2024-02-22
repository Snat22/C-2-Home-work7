using Task1;

var rec = new Rectangle();
try
{
System.Console.WriteLine("Write two number fokr find those perimeter and Area:");
System.Console.Write("First Number:");
rec.Widht = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Second Number:");
rec.Height = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Perimeter: {rec.GetPerimetr()}");
System.Console.WriteLine($"Area : {rec.GetArea()}");
}
catch (FormatException)
{
    System.Console.WriteLine("You need writhe a number");
}

