namespace _03.PC_Catalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Computer
    {
        private string name;
        private decimal price;
        private Components processor;
        private Components graphicsCard;
        private Components motherBoard;
        private Components hdd;
        private Components ram;

        public Computer(string name, decimal price, string processorName, decimal processorPrice)
           : this(name, price, processorName, processorPrice, null, null, 0, null, 0, null, 0, null, 0)
        {

        }

        public Computer(string name, decimal price, string processorName, decimal processorPrice, string motherBoardName, decimal motherBoardPrice) 
            : this(name, price, processorName, processorPrice, null, motherBoardName, motherBoardPrice, null, 0, null, 0, null, 0)
        {

        }

        public Computer(string name, decimal price, string processorName, decimal processorPrice, string processorDetails,
                        string graphicsCardName, decimal graphicsCardPrice,
                        string motherBoardName, decimal motherBoardPrice,
                        string hddName, decimal hddPrice,
                        string ramName, decimal ramPrice)
        {
            this.Name = name;
            this.Price = price;
            this.Processor = new Components(processorName, processorPrice, processorDetails);
            this.GraphicsCard = new Components(graphicsCardName, graphicsCardPrice);
            this.MotherBoard = new Components(motherBoardName, motherBoardPrice);
            this.Hdd = new Components(hddName, hddPrice);
            this.Ram = new Components(ramName, ramPrice);
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name cannot be null / whitespaces");
                }

                this.name = value;
            }
        }

        public Components Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }

        public Components GraphicsCard
        {
            get { return this.graphicsCard; }
            set { this.graphicsCard = value; }
        }

        public Components MotherBoard
        {
            get { return this.motherBoard; }
            set { this.motherBoard = value; }
        }

        public Components Hdd
        {
            get { return this.hdd; }
            set { this.hdd = value; }
        }

        public Components Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public decimal Price
        {
            get { return this.Processor.Price + this.GraphicsCard.Price +
                    this.MotherBoard.Price + this.Hdd.Price + this.Ram.Price +
                    this.price; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The price should be greater than 0");
                }

                this.price = value;
            }
        }
        
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(new string('-', 40));
            result.AppendLine(string.Format("Name: {0}", this.Name));
            result.AppendLine(string.Format("Price: {0}", this.Price.ToString("C", new CultureInfo("bg-BG"))));
            AddComponentToResult(this.Processor, result, "Processor");
            AddComponentToResult(this.GraphicsCard, result, "Graphics card");
            AddComponentToResult(this.MotherBoard, result, "Motherboard");
            AddComponentToResult(this.Ram, result, "RAM");
            AddComponentToResult(this.Hdd, result, "HDD");
            result.AppendLine(new string('-', 40));


            return result.ToString();
        }

        public void AddComponentToResult(Components component, StringBuilder result, string componentType)
        {
            if (component.Name != null)
            {
                result.AppendLine(string.Format("-->{0}: {1}", componentType, component.Name));
                if (component.Details != null)
                {
                    result.AppendLine(string.Format("   {0} Details: {1}", componentType, component.Details));
                }
                result.AppendLine(string.Format("   {0} price: {1}", componentType, component.Price.ToString("C", new CultureInfo("bg-BG"))));
            }
        }
    }
}
