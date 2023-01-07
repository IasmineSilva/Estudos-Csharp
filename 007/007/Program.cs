using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            String NovaFrase = "";

            do
            {
                Console.WriteLine("Digite sua frase (ate 50 characteres) :");
                frase = Convert.ToString(Console.ReadLine());

            } while (frase.Length  > 50)hg                                                                                         ;

            char[] ArrayChars = frase.ToCharArray();

            for (int x = 0; x < ArrayChars.Length; x++)
            {
                if (ArrayChars[x] != ' ')
                {
                    NovaFrase = NovaFrase + ArrayChars[x];
                }
            }
            Console.WriteLine("Nova frase: " + NovaFrase);
        }
    }
}
