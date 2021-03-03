using System;

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
            string nomePess;

            Console.WriteLine("Dados de entrada");
            Console.WriteLine("=============================");
            Console.Write("Digite seu nome: ");
            nomePess=Console.ReadLine();

            Console.WriteLine("DADOS DE SAIDA");
            Console.WriteLine("=============================");
            Console.WriteLine($"seu nome é: {nomePess}, O trem doido");      

 
        

        }
    }
}
