namespace _02.LaptopShop
{
    using System;

    class ConsoleClient
    {
        static void Main(string[] args)
        {
            var lenovo = new Laptop("Lenovo Yoga 2 Pro", 699);
            var dell = new Laptop("Dell Inspiron N5110R", "Dell", "Intel Core i7-4210U (4-core, 2.20 GHz, 6MB cache)",
                                    "8 GB", "nVidia GForce GT500M ", "600 GB", "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                                    "Li-Ion, 4-cells, 2550 mAh", 4.5, 699);

            Console.WriteLine(lenovo);
            Console.WriteLine(dell);
        }
    }
}
