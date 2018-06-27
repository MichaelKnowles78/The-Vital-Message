using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Vital_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("VITAL MESSAGE");
            Console.WriteLine();
            Console.WriteLine("HOW DIFFICULT? (4-10)");

            int messageLength;
            while(!Int32.TryParse(Console.ReadLine(), out messageLength) || messageLength > 10 || messageLength < 4)
            {
                Console.WriteLine("HOW DIFFICULT? (4-10)");
            }

            string message = "";
            Random rnd = new Random();
            for(int i=0; i < messageLength; i++)
            {
                message += Convert.ToChar(rnd.Next(65, 90));
            }

            Console.Clear();
            Console.WriteLine("SEND THIS MESSAGE:");
            Console.WriteLine();
            Console.WriteLine(message);

            Thread.Sleep(100*messageLength);
            Console.Clear();

            string attempt = "";
            // Reading key without echo to then write an upper case echo
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);
            while (keyPressed.Key != ConsoleKey.Enter)
            {
                Console.Write(char.ToUpper(keyPressed.KeyChar));
                attempt += char.ToUpper(keyPressed.KeyChar);
                keyPressed = Console.ReadKey(true);
            }
            Console.WriteLine();

            if (attempt == message)
            {
                Console.WriteLine("MESSAGE CORRECT");
                Console.WriteLine("THE WAR IS OVER");
            }
            else
            {
                Console.WriteLine("YOU GOT IT WRONG");
                Console.WriteLine("YOU SHOULD HAVE SENT:");
                Console.WriteLine(message);
            }

            Console.ReadKey(true);

        }
    }
}
