using System;
using System.Collections.Generic;
using AVSystemApp.Devices; // Importing devices
using AVSystemApp.Enums;   // Importing enums

namespace AVSystemApp
{
    public class AVSystem
    {
        private List<IDevice> devices;

        public AVSystem()
        {
            devices = new List<IDevice>();
        }

        // Add a new device to the system
        public void AddDevice(IDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Device {device.Name} added to the AV system.");
        }

        // Show the status of all devices
        public void ShowAllDevicesStatus()
        {
            Console.WriteLine("\n--- AV System Status ---");
            foreach (var device in devices)
            {
                device.ShowStatus();
            }
        }

        // Find a device by name
        public IDevice GetDeviceByName(string name)
        {
            return devices.Find(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
