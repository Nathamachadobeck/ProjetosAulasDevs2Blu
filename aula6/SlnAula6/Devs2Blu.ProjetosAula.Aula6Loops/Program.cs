using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controle = 0;

            do
            {
                Console.WriteLine("Informe um dos códigos Abaixo");
                Console.WriteLine("1 - Exemplo1");
                Console.WriteLine("2 - Exemplo2");
                Int32.TryParse(Console.ReadLine(), out controle);

                switch (controle)
                {
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    default:
                        break;
                }

            } while (controle > 0);
        }

        static void Exercicio1()
        {

        

        }



        static void Exemplo1()
        {
            int primo = 1;

            while (controle > 0)
            {
                Console.WriteLine("Informe o código 0 para sair");
                Int32.TryParse(Console.ReadLine(), out controle);
            }
        }

        static void Exemplo2()
        {
            Console.WriteLine("Exemplo 2");
        }
    }
}

























