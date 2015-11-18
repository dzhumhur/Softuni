namespace _02.LaptopShop
{
    using System;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, decimal price) : this(model, null, null, null, null, null, null, null, 0, price)
        {

        }

        public Laptop(string model, string manufacturer, string processor,
                        string ram, string graphicsCard, string hdd,
                        string screen, string batteryModel, double batteryLife, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = new Battery { model = batteryModel, life = batteryLife };
            this.Price = price;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The model cannot be null / whitespace");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public string Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set { this.screen = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (this.Manufacturer == null || this.Processor == null || this.Ram == null ||
                this.GraphicsCard == null || this.Hdd == null || this.Screen == null || this.Battery.life == null || this.Battery.model == null)
            {
                result = string.Format(" {0}\n|model | {1} |\n|price | {2:f2}lv          |\n {0}\n",
                                        new string ('-', this.Model.Length + "model".Length + 4),
                                        this.Model,
                                        this.Price);
                return result;
            }

            result = string.Format("model: {0}\nmanufacturer: {1}\nprocessor: {2}\nRAM: {3}\n" + 
                                    "graphics card: {4}\nHDD: {5}\nscreen: {6}\nbattery: {7}\nbattery life: {8} hours\nprice: {9:F2} lv.",
                                    this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard,
                                    this.Hdd, this.Screen, this.Battery.model, this.Battery.life, this.Price);
            return result;
        }
    }
}
