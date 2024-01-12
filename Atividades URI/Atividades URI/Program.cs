using Atividades_URI;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Produto x = new Produto();

            Console.Write("Insira o nome do produto: ");
            x.nome = Console.ReadLine();
            Console.Write("Insira o valor do produto: ");
            x.valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insira a quantidade que há do produto: ");
            x.quantidade = int.Parse(Console.ReadLine());
            
            x.total = x.ValorTotal();

            x.Informacao();

            x.continueAdd();

            x.continueRemove();


        }
    }
}