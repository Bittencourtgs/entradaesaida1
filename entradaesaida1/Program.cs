using System;

namespace entradaesaida1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            String nome = ("Alex Green");
            int aula = 3;
            double saldo = 500.500;
            String sobrenome = ("Green");
            int idade = 21;
            double altura = 1.73;

            Console.WriteLine("{0} está na aula {1}, tem o saldo de {2:f2}, sobrenome {3}, sua idade é {4} anos e tem {5} de altura", nome, aula, saldo, sobrenome, idade, altura);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

            String produto = ("Computador");
            double preço = 2500;
            int quantidade = 10;
            double total = 0;


            total = preço * quantidade;
            Console.WriteLine("O Produto {0} está no valor de {1} e na quantidade de {2} sairá no valor total de {3}", produto, preço, quantidade, total);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            
            String aluno = ("Igor");
            double introdução = 10;
            double projeto = 8.6;
            double github = 10;
            double media = 0;

            media = (introdução + projeto + github) / 3;
            Console.WriteLine($"Aluno: {aluno}");
            Console.WriteLine($"Introdução ao C#: {introdução}");
            Console.WriteLine($"Criar projeto de solução: {projeto}");
            Console.WriteLine($"Enviar ao GitHub: {github}");
            Console.WriteLine($"Média: {media:f2}");


        }
    }
}
