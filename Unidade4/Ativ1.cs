using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Faça um programa em C# (com a estrutura do...while) que leia 20 valores inteiros e:
- Encontre e mostre o maior valor;
- Encontre e mostre o menor valor;
- Calcule e mostre a média dos números lidos;

 */
namespace Unidade4
{
    internal class Ativ1
    {
        public int[] Valores = new int[20];
        public int MaiorN = 0;
        public int MenorN = 100000000;
        public double Media = 0;
        public int Indice = 0;
        public bool Interruptor = false;
        public string parada;
        public void Dados()
        {
            do
            {
                Console.WriteLine("Digite o "+(Indice+1)+"° numero inteiro: ");
                Valores[Indice]=int.Parse(Console.ReadLine());
                Media += Valores[Indice];
                if (Valores[Indice]>MaiorN) { MaiorN = Valores[Indice]; }
                if (Valores[Indice]<MenorN) { MenorN = Valores[Indice]; }
                Indice++;
                Console.WriteLine("Quer continuar? [S/N]");
                parada = Console.ReadLine().ToUpper();
                if (parada.Equals ( "N" ) || Indice > 19) { Interruptor = true; }
            } while (Interruptor== false);
            for (int i = 0; i < Indice; i++)
                { Console.WriteLine((i + 1)+"° número é "+Valores[i]); }
            Console.WriteLine("O maior valor é "+ MaiorN);
            Console.WriteLine("O menor valor é " + MenorN);
            Console.WriteLine("A media é " + (Media/(Indice-1)));
        }
      

        
        
       

    }
}
