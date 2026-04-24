using System;

namespace Lab1
{
    class Computer
    {
        public int InventoryNumber;
        public double CpuFrequency;
        public int HardDiskSize;

        public void Show()
        {
            Console.WriteLine($"Инвентарный номер: {InventoryNumber}");
            Console.WriteLine($"Частота процессора: {CpuFrequency} ГГц");
            Console.WriteLine($"Объем жесткого диска: {HardDiskSize} ГБ");
        }

        public double CalculateMemoryCost(double pricePerGB)
        {
            return HardDiskSize * pricePerGB;
        }
    }

    class Program
    {
        static void Main()
        {
            Computer myComputer = new Computer();
            myComputer.InventoryNumber = 123345;
            myComputer.CpuFrequency = 1.5;
            myComputer.HardDiskSize = 400;
            myComputer.Show();
            double totalCost = myComputer.CalculateMemoryCost(100);
            Console.WriteLine($"Стоимость жесткого диска: {totalCost} руб.");
            Console.ReadKey();
        }
    }
}