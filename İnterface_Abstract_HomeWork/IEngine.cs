using İnterface_Abstract_HomeWork.Models;

namespace İnterface_Abstract_HomeWork;

internal interface IEngine
{

    public float HorsePower { get; set; }
    public float TankSize { get; set; }
    public float CurrentOil { get; set; }
    public string FuelType { get; set; }
    public void RemainOilAmount()
    {
        Console.WriteLine(TankSize - CurrentOil);
    }

}
