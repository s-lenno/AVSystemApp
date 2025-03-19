using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AVSystemApp.Devices
{
    public class VideoDevice : IDevice
    {
        public string Name { get; }
        public string Resolution { get; private set; }
        public bool IsPlaying { get; private set; }

        public VideoDevice(string name, string resolution)
        {
            Name = name;
            Resolution = resolution;
            IsPlaying = false;
        }

        public void Play()
        {
            IsPlaying = true;
            Console.WriteLine($"{Name} is now playing.");
        }

        public void Stop()
        {
            IsPlaying = false;
            Console.WriteLine($"{Name} has stopped playing.");
        }

        public void ChangeResolution(string resolution)
        {
            Resolution = resolution;
            Console.WriteLine($"{Name} resolution changed to {Resolution}");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"[Video] {Name} - Resolution: {Resolution}, Playing: {IsPlaying}");
        }
    }
}

