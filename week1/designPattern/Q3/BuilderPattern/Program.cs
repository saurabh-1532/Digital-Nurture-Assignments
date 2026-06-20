using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Building Basic Office Desktop...");

        Computer officePC = new Computer.SystemBuilder("Intel Core i5", "16GB")
            .AddStorage("512GB SSD")
            .IncludeGPU(false)
            .BuildSystem();

        officePC.DisplaySpecs();

        Console.WriteLine("Building High-End Gaming Rig...");

        Computer gamingPC = new Computer.SystemBuilder("AMD Ryzen 9", "32GB")
            .AddStorage("2TB NVMe SSD")
            .IncludeGPU(true)
            .BuildSystem();

        gamingPC.DisplaySpecs();
    }
}
