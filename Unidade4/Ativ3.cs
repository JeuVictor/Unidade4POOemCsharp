using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Questão 3: Faça o seguinte programa em C#.
 * A prefeitura de Luziânia fez uma pesquisa com 200 pessoas, 
 * coletando dados sobre o salário e o número de filhos. A prefeitura deseja saber:
- A média do salário dessas pessoas.
- A média do número de filhos.
- O maior salário.

 */
namespace Unidade4
{
    internal class Ativ3
    {
        public double salario;
        public double MediaSalario;
        public int filhos;
        public double MediaFilhos;
        public int Id;
        public bool Interruptor = false;
        public string parada;
        public double MaiorSal;
        public double MenorSal=10000000000;
        public double Porcentagem;

        public void Dados() 
        {
            Console.WriteLine("Digite o Salário: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de filhos: ");
            filhos = int.Parse(Console.ReadLine());
            ;
        }
      

    }
}
