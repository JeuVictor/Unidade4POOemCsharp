using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Questão 2: Faça o seguinte programa em C#. Uma loja utiliza o código V
 * para compras à vista e o código P para compras a prazo. 
 * Faça um algoritmo que recebe o código (V ou P) e o valor de 15 transações.
 * Calcule e mostre:
- O valor total das compras à vista.
- O valor total das compras a prazo.
- O valor total das compras efetuadas.

 */
namespace Unidade4
{
    internal class Atv2
    {
        public string Venda { get; set; }
        public double Valor { get; set; }
        public double Prazo { get; set; }
        public double ValorTotal { get; set; }
        public double ValorPrazo { get; set; }
        public int Indice = 0;
        public bool Interruptor = false;
        public string parada;
        public void Dados()
        {
            do
            {
                Console.WriteLine("Digite o valor da "+ (Indice+1)+"° transação: ");
                Valor = double.Parse(Console.ReadLine());
                ValorTotal += Valor;
                Console.WriteLine("Quer continuar? [S/N]");
                parada = Console.ReadLine().ToUpper();
                Indice++;
                if (parada.Equals("N") || Indice > 14) { Interruptor = true; }
            } while (Interruptor == false);
            Console.WriteLine("Deseja realizar a compra a prazo ou a vista? [P/V]");
            Venda = Console.ReadLine().ToUpper();
            if (Venda.Equals("V")) { Console.WriteLine(" O Valor a vista é de R$" + ValorTotal); }
            else if (Venda.Equals("P")) 
            { 
                Console.WriteLine("Digito o prazo desejado: ");
                Prazo = double.Parse(Console.ReadLine());
                ValorPrazo = ValorTotal / Prazo;
                Console.WriteLine("O Valor total das transações é de R$"+ ValorTotal);
                Console.WriteLine("O valor das parcelas a prazo será de R$" + ValorPrazo);
             }
            else { Console.WriteLine("ERROR!! Codigo de venda errado!"); }
        }
    }
}
