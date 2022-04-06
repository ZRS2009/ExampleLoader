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
            // console title !
            Console.Title = "Example Loader";

            // logo and text
            Login.Menu();

            Console.ForegroundColor = ConsoleColor.Blue;
            string text1 = "Example loader made by insolepasteur#9999";
            string option1 = "\n[1] Discord\n";

            Console.WriteLine(text1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(option1);

            string choose = Console.ReadLine();

            // if you choose option 1 open discord
            if (choose == "1")
            {
                var prc = new ProcessStartInfo("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
                prc.Arguments = ("https://discord.gg/uR9UDq7JVd");
                Process.Start(prc);
            } else
            {
                Console.WriteLine("Error " + "'" + choose + "'" + "is not in the command list !");
            }

         
            Console.ReadLine();
        }
    }
}
