using System;
using System.Threading.Tasks;

namespace Assincrono
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tecle algo para iniciar...\n ");
            Console.ReadKey();

            await Aguardar(5);

            Console.WriteLine("Já passou 5 segundos...\n");
            Console.WriteLine("Fim");
            Console.ReadKey();

            static async Task Aguardar(int tempo)
            {
                Console.WriteLine("Iniciando espera...");
                await Task.Delay(TimeSpan.FromSeconds(tempo));
                Console.WriteLine("Fim da espera...");
            }
        }
    }
}
