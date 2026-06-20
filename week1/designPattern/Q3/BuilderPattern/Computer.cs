using System;

public class Computer
{
    public string Processor { get; private set; }
    public string Memory { get; private set; }
    public string Storage { get; private set; }
    public bool HasGraphicsCard { get; private set; }

    private Computer(SystemBuilder builder)
    {
        Processor = builder.Processor;
        Memory = builder.Memory;
        Storage = builder.Storage;
        HasGraphicsCard = builder.HasGraphicsCard;
    }

    public void DisplaySpecs()
    {
        Console.WriteLine($"CPU: {Processor}");
        Console.WriteLine($"RAM: {Memory}");
        Console.WriteLine($"Storage: {Storage}");
        Console.WriteLine($"Dedicated GPU: {HasGraphicsCard}");
        Console.WriteLine("-------------------------");
    }

    public class SystemBuilder
    {
        public string Processor { get; private set; }
        public string Memory { get; private set; }
        public string Storage { get; private set; }
        public bool HasGraphicsCard { get; private set; }

        public SystemBuilder(string processor, string memory)
        {
            Processor = processor;
            Memory = memory;
        }

        public SystemBuilder AddStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public SystemBuilder IncludeGPU(bool hasGpu)
        {
            HasGraphicsCard = hasGpu;
            return this;
        }

        public Computer BuildSystem()
        {
            return new Computer(this);
        }
    }
}