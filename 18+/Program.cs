using System;

namespace _18_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtde = 0;
            int idade = 0;
            int i = 0;

            while (i < 10)
            {
                i = i + 1;
                Console.WriteLine("Informe a idade da pessoa: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 18)
                {
                    qtde = qtde + 1;
                }
            }
            Console.WriteLine("\nExistem " + qtde + " pessoas com mais de 18 anos");
            Console.ReadKey();
        }
    }
}
