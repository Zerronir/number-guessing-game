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

                    Console.WriteLine("Too high, guess lower, you still have " + chances + " chances left");
                } else if(i < num) {
                    chances--;
                    Console.WriteLine("Too low, guess higher, you still have " + chances + " chances left");
                } else if(chances == 0) {
                    Console.WriteLine("You loose, the correct number was... " + num);
                    control = true;
                } else if(i == num) {
                    Console.WriteLine("YAAAY YOU WON!!! Guessed in: " + loops + " chances");
                    control = true;
                }


            } while(control == false);
            Console.WriteLine();
            Console.Write("To finish, please press any key to continue");
            Console.ReadKey(true);
        }
    }
}
