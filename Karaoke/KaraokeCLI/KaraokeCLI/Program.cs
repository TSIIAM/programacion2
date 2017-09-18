using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraokeCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = {"allthistime","endoftheworld","itsasmallworld"};
            Console.WriteLine("Bienvenido al Karaoke");
            while (true)
            {
                Console.WriteLine("Elige una Cancion");
                Console.WriteLine("1 para Jonathan Coulton All this time");
                Console.WriteLine("2 para End of the World");
                Console.WriteLine("3 para Its a Small World");
                Console.WriteLine("Ingresa 'Salir' para salir del programa");

                string response = Console.ReadLine();

                if (response.ToLower() == "salir") {
                    break;
                }
                var song = 0;
                if (!int.TryParse(response, out song)) {
                    Console.WriteLine("Error, intenta de nuevo.");
                    continue;
                }
                else
                song--;

                var fileName = songs[song]+".txt";
                Console.WriteLine(fileName); 

                if (!File.Exists(fileName)) {
                    Console.WriteLine("El archivo no se encuentra, intenta de nuevo");
                    continue;
                }

                var lines = File.ReadAllLines(fileName);
                Console.WriteLine("==========================================");
                foreach (var line in lines) {
                    Singer.WriteLine(line);
                }
                Console.WriteLine("==========================================");
            }
           

        }
    }
}
