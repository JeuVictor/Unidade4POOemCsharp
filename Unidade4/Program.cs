using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            config Config = new config();
            Config.mensagem();
            Console.WriteLine("Digite a questão: ");
            Config.Questao = int.Parse(Console.ReadLine());
            if (Config.Questao == 1)
            {
                Ativ1 ativ1 = new Ativ1();
                ativ1.Dados();
            }
            else if (Config.Questao == 2)
            {
                Atv2 atv2 = new Atv2();
                atv2.Dados();
            }
            else if (Config.Questao == 3)
            {
                Ativ3 obj = new Ativ3();
                List<Ativ3> Pessoa = new List<Ativ3>();
                do
                {
                    Ativ3 ativ3 = new Ativ3();
                    Console.WriteLine("Digite o Salário: ");
                    ativ3.salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de filhos: ");
                    ativ3.filhos = int.Parse(Console.ReadLine());
                    ativ3.Id++;
                    Config.id++;
                    if (ativ3.salario > obj.MaiorSal)
                    { obj.MaiorSal = ativ3.salario; }
                    if (ativ3.salario < obj.MenorSal)
                    { obj.MenorSal = ativ3.salario; }
                    if (ativ3.salario < 1500)
                    obj.Porcentagem++;
                    obj.MediaFilhos += ativ3.filhos;
                    obj.MediaSalario += ativ3.salario;
                    Console.WriteLine("Quer continuar? [S/N]");
                    ativ3.parada = Console.ReadLine().ToUpper();
                    if (ativ3.parada.Equals("N") || ativ3.Id > 199) { Config.Parar= true; }
                } while (Config.Parar == false);


                /*for (int i = 0; i < ativ3.Id ; i++)*/
                
             foreach (var item in Pessoa)
                    
             {
                        Console.WriteLine(String.Format("\nQuantidade de filhos: {0}", item.filhos));
                        Console.WriteLine($"\nSalario R$: {item.salario}");
                        Console.WriteLine($"\nId da pessoa: {(item.Id + 1)}");

             }
                Console.WriteLine("A Média de filhos em Luziania é "+(obj.MediaFilhos / Config.id));
                Console.WriteLine("A Média de salario é de R$"+(obj.MediaSalario / Config.id));
                Console.WriteLine("O maior salário é de R$"+obj.MaiorSal);
                Console.WriteLine("O Menor salário é de R$" + obj.MenorSal);
                Console.WriteLine("A Porcentagem de pessoas com salario abaixo de R$1500,00 é de "+(obj.Porcentagem/Config.id*100)+"%.");


                Console.ReadKey();
            }



        }
    }
}

