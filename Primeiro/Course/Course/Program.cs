using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            int N1 = 3 + 4 * 2;
            int N2 = (3 + 4) * 2;
            int N3 = 17 % 3;
            double N4 = 10.0 / 8.0;
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = b * b - 4.0 * a * c;
            double y1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
            Console.WriteLine(delta);
            Console.WriteLine(y1);

        }
    }
}

