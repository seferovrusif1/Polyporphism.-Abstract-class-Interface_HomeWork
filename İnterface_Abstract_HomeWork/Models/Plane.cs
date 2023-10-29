namespace İnterface_Abstract_HomeWork.Models;

internal class Plane: Vehicle,IEngine
{

    public float WingLenth { get; init; }
    public float HorsePower { get;  init; }
    public float TankSize { get; init; }
    public float CurrentOil { get; set; }
    public string FuelType { get; init; }

   

   
}
