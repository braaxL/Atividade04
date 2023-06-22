using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade04
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            string produto1;
            string quantidade;
            string produto2;
            string quantidade2;





            Console.WriteLine("Bem-Vindo ao sistema de estoque do Bruno");
            Console.WriteLine("Digite o nome do funcionário responsável: ");
            nome = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"O cadastro de estoque será feito no nome de {nome} \n\n");

            Console.WriteLine("-- CADASTRO DE PRODUTOS");
            Console.WriteLine("Digite o nome do Produto 1: ");
            produto1 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto1}");
            quantidade = Console.ReadLine();
            Int32.Parse(quantidade);


            Console.WriteLine("Digite o nome do Produto 2: ");
            produto2 = Console.ReadLine();
            Console.WriteLine($"Digite a quantidade em estoque de {produto2}");
            quantidade2 = Console.ReadLine();
            Int32.Parse(quantidade2);
            Console.WriteLine("\n");

            Console.WriteLine("- Os produtos foram cadastrados com sucesso! \n");
            Console.WriteLine($"-- LISTAS DE PRODUTOS CADASTRADOS POR {nome}: ");
            Console.WriteLine($"- {produto1} contém {quantidade} itens em estoque ");
            Console.WriteLine($"- {produto2} contém {quantidade2} itens em estoque ");


            Console.WriteLine($"- Total de itens no estoque: {Convert.ToInt32(quantidade) + Convert.ToInt32(quantidade2)}");
            Console.WriteLine("\n\n");
            Console.WriteLine("(/◕ヮ◕)/ ----- FIM DO SISTEMA ----- (/◕ヮ◕)/");
            Console.WriteLine("");
            Console.ReadKey();




        }
    }
}
