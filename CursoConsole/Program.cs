using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, operacao;
            String cliente = "", produto = "";
            Console.Clear();
            Console.WriteLine("1- Cliente");
            Console.WriteLine("1- Produto");
            Console.WriteLine("1- Sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {

                case 1:
                    Console.WriteLine("1- Cadstrar cliente");
                    Console.WriteLine("2- Consultar Cliente");
                    break;
                case 2:
                    Console.WriteLine("1- Cadstrar produto");
                    Console.WriteLine("2- Consultar produto");
                    break;
                case 3:
                    Console.WriteLine("Saindo da Aplicação");
                    break;
                default:
                    Console.WriteLine("operação invalida");
                    break;


            }
        }

    }
}
