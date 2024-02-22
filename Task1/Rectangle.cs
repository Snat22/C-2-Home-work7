namespace Task1;

public class Rectangle
{
    public int Widht { get; set; }
    public int Height { get; set; }
    public string Color { get; set; }

    public int GetArea()
    {
        int s =  Height * Widht;
        return  s;
    }
    public int GetPerimetr()
    {
        int perimetr = 2 * (Widht * Height);
        return perimetr;
    }
}
