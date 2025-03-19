using System;
using AVSystemApp.Devices;
using AVSystemApp.Helpers;

namespace AVSystemApp
{
    class Program
    {
        static void Main()
        {
            AVSystem avSystem = new AVSystem();

            // Create Devices
            AudioDevice speaker = new AudioDevice("Conference Room Speaker");
            VideoDevice projector = new VideoDevice("Main Projector", "1080p");

            // Add Devices to the System
            avSystem.AddDevice(speaker);
            avSystem.AddDevice(projector);

            bool running = true;
            while (running)
            {
                InputHelper.ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        speaker.IncreaseVolume();
                        break;
                    case "2":
                        speaker.DecreaseVolume();
                        break;
                    case "3":
                        speaker.ToggleMute();
                        break;
                    case "4":
                        projector.Play();
                        break;
                    case "5":
                        projector.Stop();
                        break;
                    case "6":
                        Console.Write("Enter new resolution (e.g., 4K, 1080p, 720p): ");
                        string resolution = Console.ReadLine();
                        projector.ChangeResolution(resolution);
                        break;
                    case "7":
                        avSystem.ShowAllDevicesStatus();
                        break;
                    case "8":
                        running = false;
                        Console.WriteLine("Exiting AV System...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
