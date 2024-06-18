using System;

namespace MyApp
{
    internal class Program
    {
        private static int Vitorias;
        private static int Derrotas;
        private static string Patente;
        private static int Placar = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Quantas Vitorias o Agente teve? ");
            Vitorias = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas Derrotas o Agente teve? ");
            Derrotas = int.Parse(Console.ReadLine());
            Placar = Vitorias - Derrotas;

            Nivel();
            Console.WriteLine($"O Herói tem de saldo de {Placar} está no nível de {Patente}");
        }

        private static void  Nivel()
        {
            if (Placar <= 10)
                Patente = "Ferro";
            else if (Placar >= 11 && Placar <= 20)
                Patente = "Bronze";
            else if (Placar >= 21 && Placar <= 50)
                Patente = "Prata";
            else if (Placar >= 51 && Placar <= 80)
                Patente = "Ouro";
            else if (Placar >= 81 && Placar <= 90)
                Patente = "Diamante";
            else if (Placar >= 91 && Placar <= 100)
                Patente = "Lendario";
            else {
                Patente = "Imortal";
            }
        }
    }
}

