using System;
using AVSystemApp.Devices;

namespace AVSystemApp.Helpers
{
    public static class InputHelper
    {
        public static void ShowMenu()
        {
            Console.WriteLine("\n--- AV System Menu ---");
            Console.WriteLine("1. Increase Speaker Volume");
            Console.WriteLine("2. Decrease Speaker Volume");
            Console.WriteLine("3. Mute/Unmute Speaker");
            Console.WriteLine("4. Play Video");
            Console.WriteLine("5. Stop Video");
            Console.WriteLine("6. Change Video Resolution");
            Console.WriteLine("7. Show System Status");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
        }
    }
}
