using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.WriteLine("\n\nEsses foram os números digitados: ");
            foreach (int t in numeros) Console.WriteLine(t);

            int[] numeros1 = numeros.Distinct().ToArray();

            Console.WriteLine("\nArray sem numeros duplicados: ");
            foreach (int u in numeros1) Console.WriteLine(u);

            Array.Reverse(numeros1);

            Console.WriteLine("\nImpares em forma decrescente: ");
            foreach (int v in numeros1){

                if(v % 2 == 1)
                {
                    Console.WriteLine(v);
                }

  

            }

        }
    }
}
