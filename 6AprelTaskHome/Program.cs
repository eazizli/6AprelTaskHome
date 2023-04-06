using _6AprelTaskHome;

internal class Program
{
    private static void Main(string[] args)
    {
       string a= Console.ReadLine();
        if (a == "1")
        {

        Square square = new Square(4);
        
        Console.WriteLine( square.CalcArea());
            Console.WriteLine(square.CalcPerimeter());
        }
        if (a == "2")
        {

        Rectangle rectangle = new Rectangle(3,10);
        Console.WriteLine(rectangle.CalcArea());
            Console.WriteLine(rectangle.CalcPerimeter());
        }


        if (a == "3")
        {

        Circle circle = new Circle(5);
        Console.WriteLine(circle.CalcArea());
        Console.WriteLine(circle.CalcPerimeter());
        }

    }
}