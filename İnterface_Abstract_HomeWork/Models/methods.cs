using System.Reflection.Emit;

namespace İnterface_Abstract_HomeWork.Models;

internal class methods
{
    public Vehicle[] Vehicles=new Vehicle[0];

    public void AddVehicle(Vehicle vehc)
    {
        Array.Resize(ref Vehicles, Vehicles.Length + 1);   //Resize eledik arrayi +1 uzunluqa getirdik
        Vehicles[Vehicles.Length - 1] = vehc;            //sonuncu indexe yeni obyekti add eledik

        Console.WriteLine("Vehicle Aded\n");
    }

    public void RemoveVehicle(string idCode)
    {
        bool _isfound = false;    //eger tapilmasa consola mesaj vermek ucun isledeceyik
        
        for (int j = 0; j < Vehicles.Length && _isfound==false; j++)
        {
            if (Vehicles[j].IdCode == idCode)
            {
                _isfound = true;
                Vehicle[] VehiclesTemp = new Vehicle[Vehicles.Length - 1];
                // yeni temp array yaradib diger arrayda silinmesi gereken userden basqalarini bu arraya menimsedirik
                //sonda evvelki arrayi resize edib temp arraya beraber edirik
                int l = 0;
                for (int i = 0; i < VehiclesTemp.Length; i++)
                {
                    if (Vehicles[i].IdCode == idCode)
                    {
                        l++;
                    }
                    VehiclesTemp[i] = Vehicles[l];
                    l++;

                }

                Array.Resize(ref Vehicles, Vehicles.Length - 1);
                Vehicles = VehiclesTemp;
                Console.WriteLine("\nUser Removed\n");
            }
            if (!_isfound)
            {
                Console.WriteLine("Istifadechi tapilmadi!");
            }
        }
    }

    public void GetAllCarsId()
    {
        foreach (var item in Vehicles)
        {
            Console.WriteLine(item.IdCode);
        }
    }
    public void GetInfo(string idCode)
    {
        bool _isfound = false;

        //_isfound = false;     //eger tapilmasa consola mesaj vermek ucun isledeceyik
        for (int j = 0; j < Vehicles.Length; j++)
        {
            if (Vehicles[j].IdCode == idCode)
            {
                _isfound = true;

                if (Vehicles[j] is Car c)
                {
                    Console.WriteLine(
        $@"Car:
Vehicle ID:       {c.IdCode}
Drive Path:       {c.DrivePath} KM
Drive Time:       {c.DriveTime} saat
HorsePower:       {c.HorsePower} at gucu
DoorCount:        {c.DoorCount} eded
WinCode:          {c.WinCode}
WheelThickness:   {c.WheelThickness} sm
TransmissionKind: {c.TransmissionKind}
TankSize:         {c.TankSize} l
CurrentOil:       {c.CurrentOil} l
FuelType:         {c.FuelType}
AverageSpeed:     {c.AverageSpeed()} Km/S
");
                }
                else if (Vehicles[j] is Plane p)
                {
                    Console.WriteLine(
        $@"Plane:
Vehicle ID:       {p.IdCode}
Drive Path:       {p.DrivePath} KM
Drive Time:       {p.DriveTime} saat
Wing Lenth:       {p.WingLenth} sm
HorsePower:       {p.HorsePower} at gucu
TankSize:         {p.TankSize} l
CurrentOil:       {p.CurrentOil} l
FuelType:         {p.FuelType}
AverageSpeed:     {p.AverageSpeed()} Km/S
");
                }
                else if (Vehicles[j] is Bicycle b)
                {
                    Console.WriteLine(
        $@"Bicycle:
Vehicle ID:        {b.IdCode}
Drive Path:       {b.DrivePath} KM
Drive Time:       {b.DriveTime} saat
Pedal Kind:        {b.PedalKind} 
Wheel Thickness:   {b.WheelThickness} sm
Transmission Kind: {b.TransmissionKind}
AverageSpeed:      {b.AverageSpeed()} Km/S
");
                }
            }
        }
                if (!_isfound)
                {
                    Console.WriteLine("Istifadechi tapilmadi!");
                }
    }

}
