using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02LaptopShop
{
    public class Laptop
    {

        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private decimal price;
        private Battery battery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }
        public Laptop(string model, decimal price, string manufacturer,
            string processor, int ram, string graphicCard, string hdd, string screen, Battery battery)
            :this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for Model");
                }

                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for Manufacturer");
                }

                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for Processor");
                }

                this.processor = value;
            }
        }

        public int  Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be negative number !");
                }

                this.ram = value;
            }
        }

        public string GraphicCard
        {
            get
            {
                return this.graphicCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for GraphicCard");
                }

                this.graphicCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for HDD");
                }

                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Cannot be empty string for Screen");
                }

                this.screen = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot be negative number !");
                }

                this.price = value;
            }
        }

        //public void AddBattery(Battery battery)
        //{
        //    this.battery = battery;
        //}

        public override string ToString()
        {
            string primaryInfo = string.Format("Laptop : {0}\nPrice : {1} lv.\n", this.model, this.price);
            string secondaryInfo = string.Empty;

            if (!string.IsNullOrEmpty(this.manufacturer))
            {
                secondaryInfo = secondaryInfo + string.Format("Manufacture : {0}\n", this.manufacturer);
            }
            
            if (!string.IsNullOrEmpty(this.processor))
            {
                secondaryInfo = secondaryInfo + string.Format("Processor : {0}\n", this.processor);
            }
            if (this.ram > 0)
            {
                secondaryInfo = secondaryInfo + string.Format("Ram : {0}\n", this.ram);
            }

            if (!string.IsNullOrEmpty(this.graphicCard))
            {
                secondaryInfo = secondaryInfo + string.Format("Graphic Card : {0}\n", this.graphicCard);
            }
            if (!string.IsNullOrEmpty(this.hdd))
            {
                secondaryInfo = secondaryInfo + string.Format("HDD : {0}\n", this.hdd);
            }
            if (!string.IsNullOrEmpty(this.screen))
            {
                secondaryInfo = secondaryInfo + string.Format("Screen : {0}\n", this.screen);
            }

            

            primaryInfo = primaryInfo + this.battery + secondaryInfo;

            return primaryInfo;

        }

    }
}
