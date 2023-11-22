using System;

class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public Laptop(string brand)
    {
        Brand = brand;
        IsConnected = false;
        BatteryLevel = 0;
    }

    public bool Connect()
    {
        Console.WriteLine($"{Brand} Laptop is connecting...");
        IsConnected = true;
        return true;
    }

    public void Charge(int minutes)
    {
        Console.WriteLine($"{Brand} Laptop is charging for {minutes} minutes.");
        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"{Brand} Laptop - Battery Level: {BatteryLevel}%";
       
    }
    
}
