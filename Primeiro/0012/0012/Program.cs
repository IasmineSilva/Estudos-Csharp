using System;
static void Main(string[] args){
    double yA, yB, yC, wA, wB, wC;

    Console.WriteLine("Entre com as medidas do triângulo Y:");
    yA = double.Parse(Console.ReadLine());
    yB = double.Parse(Console.ReadLine());
    yC = double.Parse(Console.ReadLine());

    Console.WriteLine("Entre com as medidas do triângulo W:");
    wA = double.Parse(Console.ReadLine());
    wB = double.Parse(Console.ReadLine());
    wC = double.Parse(Console.ReadLine());

    double p = (yA + yB + yC) / 2;
    double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

    p = (yA + yB + yC) / 2;
    double areaW = Math.Sqrt(p * (p - wA) * (p - wB) * (p - wC));
    Console.WriteLine("Área de Y =" + areaY);
    Console.WriteLine("Área de W =" + areaW);

    if (areaY > areaW) {
        Console.WriteLine("Maior área:  Y");
    }
    else {
        Console.WriteLine("Maior área:  W");
    }


}
