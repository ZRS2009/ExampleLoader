using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT
{
     class MainMenu
    {
        static void Main(string[] args)
        {
            // logo and text
            Login.Menu();

            Console.ForegroundColor = ConsoleColor.Blue;
            string text1 = "Example loader made by insolepasteur#9999";
            string option1 = "\n[1] Discord\n";

            Console.WriteLine(text1);

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(option1);
            string choose = Console.ReadLine();

            // option 1 open discord
            if (choose == "1")
            {
                var prc = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
                 prc.Arguments = ("https://discord.gg/uR9UDq7JVd");
                Process.Start(prc);
            }

            Console.ReadLine();

            // Radom console title character generator
            if (text1 == text1)
            {
                while (true)
                {
                    Console.Title = "5656858ADZSZZZDD8495";
                    Console.Title = "03L.YUKUUK58470495";
                    Console.Title = "2831724143425495";
                    Console.Title = "34RHRHTHTGH7575795";
                    Console.Title = "0JZFZFZF738495";
                    Console.Title = "802453JRNNEUIJFZF95";
                    break;
                }
            }
        }
    }
}
