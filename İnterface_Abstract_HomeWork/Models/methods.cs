namespace İnterface_Abstract_HomeWork.Models;

internal class methods
{
    public Vehicle[] Vehicles=new Vehicle[0];

    public void AddVehicle(Vehicle vehc)
    {
        Array.Resize(ref Vehicles, Vehicles.Length + 1);   //Resize eledik arrayi +1 uzunluqa getirdik
        Vehicles[Vehicles.Length - 1] = vehc;            //sonuncu indexe yeni obyekti add eledik

        Console.WriteLine("\nVehicle Aded\n");
    }

    public void RemoveUser(string idCode)
    {
        bool _isfound = false;

        //_isfound = false;     //eger tapilmasa consola mesaj vermek ucun isledeceyik
        for (int j = 0; j < Vehicles.Length; j++)
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


    public void GetInfo(Vehicle vehc) 
    {
        if (vehc is Car c)
        {
            Console.WriteLine(
$@"Car:
Vehicle ID:       {c.IdCode}
HorsePower:       {c.HorsePower}
DoorCount:        {c.DoorCount}
WinCode:          {c.WinCode}
WheelThickness:   {c.WheelThickness}
TransmissionKind: {c.TransmissionKind}
TankSize:         {c.TankSize}
CurrentOil:       {c.CurrentOil}
FuelType:         {c.FuelType}");
        }
        else if (vehc is Plane p)
        {
            Console.WriteLine(
$@"Plane:
Vehicle ID:       {p.IdCode}
Wing Lenth:       {p.WingLenth}
HorsePower:       {p.HorsePower}
TankSize:         {p.TankSize}
CurrentOil:       {p.CurrentOil}
FuelType:         {p.FuelType}");
        }
        else if (vehc is Bicycle b)
        {
            Console.WriteLine(
$@"Bicycle:
Vehicle ID:        {b.IdCode}
Pedal Kind:        {b.PedalKind} 
Wheel Thickness:   {b.WheelThickness}
Transmission Kind: {b.TransmissionKind}");
        }
    }

}
