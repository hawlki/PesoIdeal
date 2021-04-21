using System;

namespace pesoideal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("------------------------------");
            Console.WriteLine("          Peso ideal          ");
            Console.WriteLine("------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite sua altura: ");
            bool alturaValida = decimal.TryParse(Console.ReadLine(), out decimal altura);
            Console.Write("Digite seu sexo (use [M] para masculino ou [F] para feminino): ");
            string sexo = Console.ReadKey().KeyChar.ToString().ToUpper();
            Console.WriteLine();

            if(!alturaValida)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite a altura correta");
                Console.ResetColor();
                Environment.Exit(1);
            }

            decimal pesoIdealM = altura * 72.7m - 58.0m; 
            decimal pesoIdealF = altura * 62.1m - 44.7m;

            if(sexo.Equals("M"))
            {    
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Seu peso ideal é {pesoIdealM:N1}kg");
                Console.ResetColor();
                Environment.Exit(1);
            }        

            else if(sexo.Equals("F"))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Seu peso ideal é {pesoIdealF:N1}kg");
                Console.ResetColor();
                Environment.Exit(1);
            }

            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sexo inválido");
                Console.ResetColor();
                Environment.Exit(1);
            }
        }
    }
}
