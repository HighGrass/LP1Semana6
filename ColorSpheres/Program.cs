using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Color red = new Color(255, 0, 0, 255);

            Sphere sphere = new Sphere(red, 10);
            Console.WriteLine(sphere.GetColor().GetRed());
            Console.WriteLine(sphere.GetRadius());
            sphere.Pop();
            Console.WriteLine(sphere.GetRadius());
        }
    }
}
