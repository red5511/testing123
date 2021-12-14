using System;

namespace równanie_kwadratowe { 
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Podaj pierwiastki do równania kwadratowego: ax^2+bx+c ");
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");

            float b = float.Parse(Console.ReadLine());
            Console.Write("c= ");
            float c = float.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;

            if (delta > 0) {
                double x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Wynikiem są prawdziwe 2 pierwiastki: " + x1 + x2);
            } else if (delta < 0) {
                delta = -delta;
                double x3 = -b / (2 * a);
                double x4 = System.Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Wynikiem są nie realne 2 pierwiastki: " + x3 + x4);
            } else {
                double x5 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Wynikiem jest pierwiastem: " + x5);
            } 
        } 
    }
}