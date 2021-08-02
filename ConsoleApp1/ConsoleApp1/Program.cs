using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIAREMOS MÉTODOS PARA SEREM EXECUTADOS AO MESMO TEMPO !
            Stopwatch sw = new Stopwatch();
            sw.Start();
            RealizarOperacao(1, "Fulano ", "da Silva ");
            RealizarOperacao(2, "Beltrano ", "da Silva ");
            RealizarOperacao(3, "Sicrano ", "da Silva ");
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milissegundos.");
        }
        static void RealizarOperacao(int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação {op}...");
            for(int i = 0; i< 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 35);
            }
            Console.WriteLine($"Finalizando operação {op}...");
        }
    }
}
