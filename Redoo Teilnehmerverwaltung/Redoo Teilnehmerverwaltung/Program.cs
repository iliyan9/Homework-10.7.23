using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redoo_Teilnehmerverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teilnhemer teilnehmer = new Teilnehmer();
            string headertext = "Teilnehmer Verwaltung v3.0"

                CreateHeader(headertext, ConsoleColor, Blue, true);

            Console.WriteLine("Bitte geben Sie die Teilnehmer Daten ein: ");
            teilnehmer = GetStudentInfo();

            DisplayStudentInfo(teilnehmer);
        }

        private static void DisplayStudentInfo(Teilnehmer studentInfo)
        {
            Console.WriteLine("\nDie Teilnehmerdater: \n");

            Console.WriteLine($"\t{studentInfo.Name}, {studentInfo.Nachname}, {studentInfo.Geburtsdatum.ToShortDateString()}, {studentInfo.Plz}, {studentInfo.Ort}");
        }

        private static void CreateHeader(string headertext, ConsoleColor headerTextColor, object blue, bool clearScreen)
        {
            int xTitelPos = 0;

            if (clearScreen)
            {
                Console.Clear();
            }

            //Darstellung Programm Header            
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine(new string('*', Console.WindowWidth - 1));

            //cursor f. Titel Ausgabe positionieren
            xTitelPos = (Console.WindowWidth - (headertext.Length + 2)) / 2;
            Console.SetCursorPosition(xTitelPos, 1);

            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = headerTextColor;
            Console.Write(" " + headertext + " ");
            Console.ForegroundColor = oldColor;

            //alte cursor Position wiederherstellen
            Console.SetCursorPosition(0, 4);
            //Consolen Fensterbezeichnung setzen
            Console.Title = headertext;
        }

        private static Teilnehmer GetStudentInfo()
        {
            Teilnehmer teilnehmer;

            teilnehmer.Name = ReadString("\tVorname: ");
            teilnehmer.Nachname = ReadString("\tNachname: ");
            teilnehmer.Geburtsdatum = ReadDateTime("\tGeburtsdatum: ");
            teilnehmer.Plz = ReadInt("\tPLZ: ");
            teilnehmer.Ort = ReadString("\tWohnort: ");

        }

        private static object ReadInt(string inputPrompt)
        {
            string input = string.Empty;
            int inputValue = 0;
            bool inputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                try
                {
                    inputValue = int.Parse(input);
                    inputIsValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\aERROR: Ungültige Eingabe.");
                    inputValue = 0;
                    Console.ResetColor();
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return inputValue;
        }

        private static object ReadDateTime(string inputPrompt)
        {
            string input = string.Empty;
            DateTime inputDateTime = DateTime.MinValue;
            bool inputIsValid = false;
            do
            {
                Console.Write(inputPrompt);
                input = Console.ReadLine();

                try
                {
                    inputDateTime = DateTime.ParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    inputIsValid = true;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\aERROR: Ungültige Datumseingabe.");
                    inputDateTime = DateTime.MinValue;
                    Console.ResetColor();
                    inputIsValid = false;
                }
            }
            while (!inputIsValid);

            return inputDateTime;
        }

        private static object ReadString(string InputPrompt)
        {
            string input = string.Empty;

            do
            {
                Console.Write(InputPrompt);
                input = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(input));

            return input;
        }
    }

    internal class Teilnehmer
    {
        public Teilnehmer()
        {
        }
    }
}
