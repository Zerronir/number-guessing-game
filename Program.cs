using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace c_sharp
{
    public static class MainProgam {
        public static void Main(string[] args) {
            // Create the Random object
            Random r = new Random();

            int num = r.Next(0, 100);
            int chances = 5;
            int loops = 0;

            bool control = false;

            do {
                
                Console.Write("Adivina el número de entre 0 a 100: ");
                string input = Console.ReadLine();
                loops++;
                int i = int.Parse(input);

                if(i > num) {
                    chances--;

                    Console.WriteLine("El número introducido es superior... te quedan " + chances + " intentos");
                } else if(i < num) {
                    chances--;
                    Console.WriteLine("El número introducido es inferior... te quedan " + chances + " intentos");
                } else if(chances == 0) {
                    Console.WriteLine("Has perdido el juego, el número correcto era " + num);
                    break;
                } else if(i == num) {
                    Console.WriteLine("Has adivinado el número!!! Lo has hecho en: " + loops + " intentos");
                    control = true;
                    break;
                }


            } while(control == false);
            Console.WriteLine();
            Console.Write("Para finalizar presiona cualquier tecla");
            Console.ReadKey(true);
        }
    }
}
