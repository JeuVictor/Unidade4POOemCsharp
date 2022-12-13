using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    internal class config
    {
        public int Questao;
        public bool Parar = false;
        public int id;
        public void mensagem()
        {
            Console.WriteLine("Questão 1: Faça um programa em C# (com a estrutura do...while) que leia 20 valores inteiros e:\r\n- Encontre e mostre o maior valor;\r\n- Encontre e mostre o menor valor;\r\n- Calcule e mostre a média dos números lidos;\r\n\r\n\r\nQuestão 2: Faça o seguinte programa em C#. Uma loja utiliza o código V para compras à vista e o código P para compras a prazo. Faça um algoritmo que recebe o código (V ou P) e o valor de 15 transações. Calcule e mostre:\r\n- O valor total das compras à vista.\r\n- O valor total das compras a prazo.\r\n- O valor total das compras efetuadas.\r\n\r\nQuestão 3: Faça o seguinte programa em C#. A prefeitura de Luziânia fez uma pesquisa com 200 pessoas, coletando dados sobre o salário e o número de filhos. A prefeitura deseja saber:\r\n- A média do salário dessas pessoas.\r\n- A média do número de filhos.\r\n- O maior salário.\r\n- O menor salário.\r\n- A porcentagem de pessoas com salários até R$1500,00\r\n");
            Console.WriteLine("");
        }

    }
}
