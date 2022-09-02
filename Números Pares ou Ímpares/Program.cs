using System;

namespace Números_Pares_ou_Ímpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool digitouNumeros = true;
            int resultado = 0;
            int soma = 0;

            while (true)
            {
                Console.WriteLine("O número é par ou impar?!\n");
                Console.Write("Informe um número: ");
                digitouNumeros = int.TryParse(Console.ReadLine(), out soma);
                if (!digitouNumeros)
                {
                    Console.WriteLine("\nDigite um número!!!");

                }
                else
                {
                    resultado = soma % 2;
                    if (resultado == 1 && resultado != 0)
                    {
                        Console.WriteLine("\nO número informado é impar\n");

                    }
                    else
                    {
                        Console.WriteLine("\nO número informado é par\n");
                    }
                    break;
                }


            }
            
            
            Console.ReadKey();
        }
    }
}
