using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculSwitch2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, total, op;

            Console.WriteLine("----- Escolha uma Opção: -----");
            Console.WriteLine("ADIÇÃO");
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("MULTIPLICAÇÃO");
            Console.WriteLine("DIVISÃO");

            op = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor1: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor2: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    total = valor1 + valor2;
                    Console.WriteLine("Total da soma: " + total);
                    break;
                case 2:
                    total = valor1 - valor2;
                    Console.WriteLine("Total da subtração: " + total);
                    break;
                case 3:
                    total = valor1 * valor2;
                    Console.WriteLine("Total da multiplicação: " + total);
                    break;
                case 4:
                    total = valor1 / valor2;
                    Console.WriteLine("Total da divisão: " + total);
                    break;

                default:
                    Console.WriteLine("Opção invalida!\nEscolha entre 1ª e 4ª");
                    break;

            }
            Console.ReadKey();
        }
    }
}
