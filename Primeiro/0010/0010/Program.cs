using System;
using System.Globalization;
static void Main(string[] args) {

    Console.WriteLine("Digite um número: ");
    double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    while (y >= 0.0) {
        double raiz = Math.Sqrt(y);
        Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
        Console.Write("Digite outro número: ");
        y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
    Console.WriteLine("Número negativo!");
}
  


