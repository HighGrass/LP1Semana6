using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Color red = new Color(255, 0, 0);

            Sphere sphere = new Sphere(red, 10);
            Console.WriteLine(sphere.GetColor().Red);
            Console.WriteLine(sphere.GetRadius());
            sphere.Pop();
            Console.WriteLine(sphere.GetRadius());
        }


    }
}
