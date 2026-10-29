using System;

class Shapes
{
    
    public class Circle
    {
        public void call()
        {
            Console.WriteLine("This is a class for circles.");
        }

        public class Circle2
        {
            public void show()
            {
                Console.WriteLine("This is a class for circle 2.");
                Circle c = new Circle();
                c.call();
            }
        }
    }
}

class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a class for shapes.");
        Shapes.Circle circle = new Shapes.Circle();
        circle.call();
        Shapes.Circle.Circle2 circle2 = new Shapes.Circle.Circle2();
        circle2.show();
    }
}