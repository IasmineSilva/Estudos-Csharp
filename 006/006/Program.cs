using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}
