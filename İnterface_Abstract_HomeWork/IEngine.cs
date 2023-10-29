using İnterface_Abstract_HomeWork.Models;

namespace İnterface_Abstract_HomeWork;

internal interface IEngine
{

    public float HorsePower { get; init; }
    public float TankSize { get; init; }
    public float CurrentOil { get; set; }
    public string FuelType { get; init; }
    public void RemainOilAmount()
    {
        Console.WriteLine(TankSize - CurrentOil);
    }

}
