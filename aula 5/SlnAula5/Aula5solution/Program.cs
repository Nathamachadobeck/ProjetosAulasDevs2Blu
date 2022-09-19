using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5solution
{
    class Program
    {
        static void Main(string[] args)
        {

            Questao5Desafio();

        }
        static void Exemplo1()
        {
            string fruta;

            Console.WriteLine("Qual fruta você deseja comprar?");
            Console.WriteLine("Maçã");
            Console.WriteLine("Kiwi");
            Console.WriteLine("Melancia");

            fruta = Console.ReadLine();

            switch (fruta.ToUpper())
            {

                case "MAÇÃ":
                    Console.WriteLine("Não vendemos essa fruta aqui");
                    break;
                case "KIWI":
                    Console.WriteLine("Estamos com escasses de Kiwis");
                    break;
                case "MELANCIA":
                    Console.WriteLine("Aqui está, são R$3,00 reais o Kilo!");
                    break;
                default:
                    Console.WriteLine("Produto Inválido");
                    break;
            }

        } 
        static void Exemplo2()
        {

            string revenda;

            Console.WriteLine("Bem-vindo a Revenda Relâmpago Marquinhos\n + O que você írá querer hoje?");
            Console.WriteLine("Carro Hatch");
            Console.WriteLine("Carro Sedan");
            Console.WriteLine("Motocicleta");
            Console.WriteLine("Caminhonete");

            revenda = Console.ReadLine();

            switch (revenda.ToUpper())
            {

                case "HATCH":
                    Console.WriteLine("Compra efetuada com sucesso");
                    break;
                case "SEDAN":
                    Console.WriteLine("Tem certeza que não prefere outro modelo?");
                    break;
                case "MOTOCICLETA":
                    Console.WriteLine("Tem certeza que não prefere outro modelo?");
                    break;
                case "CAMINHONETE":
                    Console.WriteLine("Tem certeza que não prefere outro modelo?");
                    break;
                default:
                    Console.WriteLine("Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }
        static void Questao5Desafio()
        {
            const int PT7 = 10;
            const int PT14 = 20;
            const int PT21 = 30;
            const int PT1a6 = 1;
            const int PT8a13 = 5;
            const int PT15a20 = 6;

            string Player1;
            string Computer;
            




            int32.TryParse(Console.ReadLine(), out optPlayer1);
            
        }
    } 
}
