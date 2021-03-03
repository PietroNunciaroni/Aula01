using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1)
            Crie um programa para ler:
            * O nome de um Time;
            * Quantidade de jogadores;
            * Se a modalidade é masculina ou feminina.
            -> Imprima os resultados

            */
            
            //Declaração de variaveis
            string nometim, tipotim, genero;
            int jogadoresti, jogadoresres, totjogadores;

            //Apresentação
            Console.WriteLine("Olá, vamos cadastrar o seu time ");
            //Entrada de valores
            Console.Write("Por Favor Digite o nome do seu time: ");
            nometim = Console.ReadLine();
            Console.Write("Seu time participara da Liga Feminina ou Masculina: ");
            genero = Console.ReadLine();
            Console.Write("Agora diga, de qual esporte seu time será: ");
            tipotim = Console.ReadLine();
            Console.Write("Qual a quantidade de jogadores titulares: ");
            jogadoresti = int.Parse(Console.ReadLine());                    //convertendo string em int
            Console.Write("Qual a quantidade de jogadores reservas: ");
            jogadoresres = int.Parse(Console.ReadLine());

            //calculando total de jogadores
            totjogadores = jogadoresres + jogadoresti;
            //dando espaços

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            //Saida de dados
            Console.WriteLine("Seu time foi cadastrado com sucesso!!!");
            Console.WriteLine($"Nome do time: {nometim}"                             +
                              $"\nModalidade: {tipotim}"                             +
                              $"\nSeu time participara da Liga {genero}"             +
                              $"\nQuantidade de jogadores titulares: {jogadoresti}"  +
                              $"\nQuantidade de jogadores na reserva: {jogadoresres}"+
                              $"\nQunatidade de jogadores no time: {totjogadores}");

        }
    }
}
