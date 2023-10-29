namespace İnterface_Abstract_HomeWork.Models;

internal class Plane: Vehicle,IEngine
{

    public float WingLenth { get; set; }
    public float HorsePower { get; set; }
    public float TankSize { get; set; }
    public float CurrentOil { get; set; }
    public string FuelType { get; set; }

   

   
}
