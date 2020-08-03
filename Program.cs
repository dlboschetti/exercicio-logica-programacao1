using System;
using System.Net;

namespace exercicio_logica_programacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdDias;
            Console.WriteLine("Favor informar o mês de 1 a 12:");
            int nMeses = Convert.ToInt32(Console.ReadLine());

            if (nMeses > 0 && nMeses <= 12)
            {
                qtdDias = nMeses * 30;
                Console.WriteLine($"Vc informmou mês {nMeses} que corresponde a {qtdDias} dias.");
            }
                
            else
                Console.WriteLine("Informação incorreta.");
        }
    }
}
