using System;

namespace AVSystemApp.Devices
{
    public class AudioDevice : IDevice
    {
        public string Name { get; }
        public int Volume { get; private set; }
        public bool IsMuted { get; private set; }

        public AudioDevice(string name)
        {
            Name = name;
            Volume = 50; // Default volume
            IsMuted = false;
        }

        public void IncreaseVolume()
        {
            if (Volume < 100) Volume += 10;
            Console.WriteLine($"{Name} volume increased to {Volume}");
        }

        public void DecreaseVolume()
        {
            if (Volume > 0) Volume -= 10;
            Console.WriteLine($"{Name} volume decreased to {Volume}");
        }

        public void ToggleMute()
        {
            IsMuted = !IsMuted;
            Console.WriteLine($"{Name} is now {(IsMuted ? "Muted" : "Unmuted")}");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"[Audio] {Name} - Volume: {Volume}, Muted: {IsMuted}");
        }
    }
}
