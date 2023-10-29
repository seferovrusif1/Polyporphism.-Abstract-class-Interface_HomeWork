namespace İnterface_Abstract_HomeWork.Models;

internal class Car : Vehicle, ITransmission, IWheel, IEngine
{
    public byte DoorCount{ get; init; }
    public string WinCode { get; init; }
    public int WheelThickness { get; set; }
    public string TransmissionKind { get; set; }
    public float HorsePower { get; set; }
    public float TankSize { get; set; }
    public float CurrentOil { get; set; }
    public string FuelType { get; set; }

    

}