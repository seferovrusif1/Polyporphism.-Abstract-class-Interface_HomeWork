namespace İnterface_Abstract_HomeWork.Models;


internal class Bicycle : Vehicle, ITransmission, IWheel
{
    public string PedalKind { get; init; }
    public string TransmissionKind { get; init; }
    public int WheelThickness { get; init; }

    
}
