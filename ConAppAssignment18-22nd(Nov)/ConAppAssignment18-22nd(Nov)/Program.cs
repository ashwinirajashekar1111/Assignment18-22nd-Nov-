
interface IConnectable
{
    bool Connect();
}

interface IRechargeable
{
    void Charge(int minutes);
}

interface IDisplayable
{
    string Display();
}



class Program
{
    static void Main()
    {
        SmartPhone myPhone = new SmartPhone("iPhone 12");
        Laptop myLaptop = new Laptop("Dell XPS");

        
        myPhone.Connect();
        myPhone.Charge(60);

        myLaptop.Connect();
        myLaptop.Charge(120);

        
        
    }
}


