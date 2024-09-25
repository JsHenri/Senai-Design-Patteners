public class UniversalRemoteControl : RemoteControl
{
    public UniversalRemoteControl(IDevice device) : base(device) { }

    public override void TurnOn()
    {
        device.TurnOn();
    }

    public override void TurnOff()
    {
        device.TurnOff();
    }

    public override void SetVolume(int volume)
    {
        device.SetVolume(volume);
    }
}