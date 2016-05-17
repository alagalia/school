using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03PcCatalog
{
    class Components
    {
        private string name;
        private string details;
        private decimal price;

        public Components(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }
        public Components(string details, decimal price) 
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //throw new ArgumentNullException("Invalid name ... must contain at last 1 character !!!");
                    this.name = "UNNAMED COMPONENT";
                }
                else
                {
                    this.name = value;
                }
                
            }
            get
            {
                return this.name;
            }
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Must be at last 1 character !!!");
                }
                this.details = value;
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
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Must be positive number !!! ");
                }
                this.price = value;
            }
        }
    }
}
