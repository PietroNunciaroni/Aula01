using System;
using System.Globalization;
namespace Aula001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa teme 2002
            Console.WriteLine("============================================");
            Console.WriteLine("Nome:..... Pietro");
            Console.WriteLine("Idade:.... 20 Anos");
            Console.WriteLine("Sexo:..... A Sei la mano");
            Console.WriteLine("Altura:... Dois mil");
            Console.WriteLine("============================================");


            //Criando o mesmo programa com variaveis
            //Área de declaração de VARIÁVEIS

            string nomePessoa;

            char sexoPessoa;

            int idadePessoa;

            double alturaPessoa, multIdadePelaAlt;




            //Área de Entrada de Dados

            Console.WriteLine("***************** DADOS DE ENTRADA *****************");

            Console.Write("Digite seu nome...........: ");

            nomePessoa = Console.ReadLine();

            Console.Write("Digite seu Sexo: F, M ou O: ");

            sexoPessoa = char.Parse(Console.ReadLine());

            Console.Write("Digite sua idade..........: ");

            idadePessoa = int.Parse(Console.ReadLine());

            Console.Write("Digite sua altura.........: ");

            alturaPessoa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            

            //Área de Cálculos

            //calculando a idade da pessoa * a altura dela

            multIdadePelaAlt = idadePessoa * alturaPessoa;



            //Área de Saída de Dados
            
            Console.WriteLine("\n\n**************** DADOS DE SAÍDA ********************");
            //aqui eu otimizo o codigo e deixo ele mais limpo e legivel de forma 
            //a nao precisa digitar sempre o mesmo comando
            Console.WriteLine($"\nSeu nome é..............................: {nomePessoa}"   +
                              $"\nSeu Sexo é..............................: {sexoPessoa}"   +
                              $"\nSua Idade é.............................: {idadePessoa}"  +
                              $"\nSua Altura é............................: {alturaPessoa.ToString("F2")}" +
                              $"\nA multiplicação  da idade * a altura é..: {multIdadePelaAlt.ToString("F2")}");
        }
    }
}
