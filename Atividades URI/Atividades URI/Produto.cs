using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Atividades_URI
{
    internal class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;
        public double total;

        public void continueAdd()
        {
            char continuar;
            do
            {
                Console.WriteLine("Deseja adicionar alguma nova unidade?(s/n) ");
                continuar = char.Parse(Console.ReadLine());

                if (continuar == 's')
                {
                    Adicionar();
                }

            } while (continuar == 's');
        }

        public void continueRemove()
        {
            char continuar;
            do
            {
                Console.WriteLine("Deseja remover alguma unidade?(s/n) ");
                continuar = char.Parse(Console.ReadLine());

                if (continuar == 's')
                {
                    Remover();
                }

            } while (continuar == 's');
        }

        public void Adicionar()
        {
            Console.WriteLine("Quantas unidades serão adicionadas?");
            int quantidadeAdicional = int.Parse(Console.ReadLine());

            quantidade += quantidadeAdicional;

            total = ValorTotal();
            Informacao();
        }

        public void Remover()
        {
            Console.WriteLine("Quantas unidades serão removidas?");
            int quantidadeRemocao = int.Parse(Console.ReadLine());

            quantidade -= quantidadeRemocao;

            total = ValorTotal();
            Informacao();
        }

        public double ValorTotal()
        {
            total = valor * quantidade;

            return total;
        }

        public void Informacao()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("O produto é: " + nome);
            Console.WriteLine("Seu valor é: " + valor.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Atualmente há: " + quantidade + " unidades no estoque");
            Console.WriteLine("O valor total da quantidade de unidades é: " + total.ToString("F2", CultureInfo.InvariantCulture)); 
        }

    }
}
