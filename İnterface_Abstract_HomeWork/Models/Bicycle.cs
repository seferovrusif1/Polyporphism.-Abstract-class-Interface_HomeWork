namespace İnterface_Abstract_HomeWork.Models;


internal class Bicycle : Vehicle, ITransmission, IWheel
{
    public string PedalKind { get; set; }
    public string TransmissionKind { get; set; }
    public int WheelThickness { get; set; }

    
}
