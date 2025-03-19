namespace AVSystemApp.Devices
{
    public interface IDevice
    {
        string Name { get; }
        void ShowStatus();
    }
}
