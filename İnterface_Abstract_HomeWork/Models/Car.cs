namespace İnterface_Abstract_HomeWork.Models;

internal class Car : Vehicle, ITransmission, IWheel, IEngine
{
    public byte DoorCount{ get; init; }
    public string WinCode { get; init; }
    public int WheelThickness { get; init; }
    public string TransmissionKind { get; init; }
    public float HorsePower { get; init; }
    public float TankSize { get; init; }
    public float CurrentOil { get; set; }
    public string FuelType { get; init; }

    

}