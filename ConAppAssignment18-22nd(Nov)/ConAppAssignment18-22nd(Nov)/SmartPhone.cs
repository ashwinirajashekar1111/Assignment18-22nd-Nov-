// SmartPhone class implementing multiple interfaces
using System;

class SmartPhone : IConnectable, IRechargeable, IDisplayable
{
    public string Model { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public SmartPhone(string model)
    {
        Model = model;
        IsConnected = false;
        BatteryLevel = 0;
    }

    public bool Connect()
    {
        Console.WriteLine($"{Model} is connecting...");
        IsConnected = true;
        return true;
    }

    public void Charge(int minutes)
    {
        Console.WriteLine($"{Model} is charging for {minutes} minutes.");
        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"{Model} - Battery Level: {BatteryLevel}%";
    }
    
        
}
