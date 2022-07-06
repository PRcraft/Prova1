using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int mediaf, trabalho1, pnota1, pnota2;
            Console.Write("Digite o nome do estudante: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do trabalho: ");
            trabalho1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da primeira avaliaçao: ");
            pnota1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da segunda avaliaçao: ");
            pnota2 = Convert.ToInt32(Console.ReadLine());
            mediaf = (trabalho1 + pnota1 + pnota2) / 3;

            if (mediaf >= 8.5)
            {
                Console.WriteLine("O conceito é A");
                Console.WriteLine("Média: " + mediaf);
            }

            else if (mediaf >= 7)
            {
                Console.WriteLine("O conceito é B");
                Console.WriteLine("Média: " + mediaf);
            }

            else if (mediaf >= 6)
            {
                Console.WriteLine("O conceito é C");
                Console.WriteLine("Média: " + mediaf);
            }

            else if (mediaf >= 0.1)
            {
                Console.WriteLine("O conceito é D");
                Console.WriteLine("Média: " + mediaf);
            }

            else if (mediaf == 0)
            {
                Console.WriteLine("O conceito é E");
                Console.WriteLine("Média: " + mediaf);
            }



            Console.ReadKey();
        }
    }
}
