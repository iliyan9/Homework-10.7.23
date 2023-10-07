using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        private static object geht;

        static void Main(string[] args)
        {
            string name = string.Empty;
            string eingabe = string.Empty;
            int alter = 0;
            string wie = string.Empty;
            string flaeche = 0.0;
            string umfang = 0.0;
            string seiteA = 0.0;
            string seiteB = 0.0;

            Console.Write("Bitte name eingeben: ");
            name = Console.ReadLine();


            Console.Write($"Wie alt bist du {name}: ");
            eingabe = Console.ReadLine();

            //eingabe = "40";
            alter = int.Parse(eingabe);

            Console.WriteLine($"{name}, Sie sind {alter} Jahre alt.");
            Console.WriteLine($"Sie wurden im Jahr {2023 - alter} geboren");
            Console.ReadLine();


            Console.Write($"Willst du ein Quiz machen?: ");
            name = Console.ReadLine();
            eingabe = Console.ReadLine();

            string titel = "  Rechtecksberechnung v1.0  ";
            Console.WriteLine(new string('*', Console WindowWidth - 1));
            Console.WriteLine(new string('*', Console WindowWidth - 1));
            Console.WriteLine(new string('*', Console WindowWidth - 1));

            xTitelPos = (Console.WindowWidth - titel.Length) / 2;
            Console.SetCursorPosition(xTitelPos, 1);
            Console.Write(titel);

            Console.SetCursorPosition(0, 4);

            Console.Titel = titel;

            Console.WriteLine($"\tRechteckdaten eingeben: ");
            Console.Write("\tSeite a: ");
            seiteA = double.Parse(Console.ReadLine());
            Console.Write("\tSeite b: ");
            seiteB = double.Parse(Console.ReadLine());

            flaeche = seiteA * seiteB;
            umfang = (seiteA + seiteB) * 2;

            Console.WriteLine("Ergebnise Rechtecksberechnung:");
            Console.WriteLine($"\tUmfang: {umfang:f2}");
            Console.WriteLine($"\tFläche: {flaeche:f2}");
            Console.WriteLine();

        }
    }
}
