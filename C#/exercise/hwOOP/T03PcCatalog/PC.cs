using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03PcCatalog
{
    class PC
    {
        private string name;
        private List<Components> component = new List<Components>();
        private decimal price;

        public PC(Components component)
        {
            this.Name = name;
            this.Component.Add(component);
        }
        public PC(string name, Components component) : this(component)
        {
            this.Name = name;
            //this.Component.Add(component);
        }
        public PC(string name, Components c1, Components c2, Components c3,Components c4, Components c5):this(name, c1)
        {
            //this.Name = name;
            //this.Component.Add(c1);
            this.Component.Add(c2);
            this.Component.Add(c3);
            this.Component.Add(c4);
            this.Component.Add(c5);

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.name = "UNNAMED";
                }
                else
                {
                    this.name = value;
                }
                
            }
        }

        public List<Components> Component
        {
            get
            {
                return this.component;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Can not generate PC without at last 1 component !");
                }
                this.component = value;
                //this.component.Add(value);
            }
        }

        public void addComponent(Components componentche)
        {
            this.component.Add(componentche);
        }

        public decimal Price
        {
            get
            {
                decimal sum = 0m;
                foreach (var chast in this.component)
                {
                    sum += chast.Price;
                }
                return sum;
            }
            
        }

        public override string ToString()
        {
            StringBuilder info =new StringBuilder(new String('-',25) + "\n");
            info.Append(string.Format("PC name: {0}\n", this.name));
            

            foreach (var compo in this.component)
            {
                CultureInfo bg = CultureInfo.GetCultureInfo("bg-BG");
                info.Append(string.Format("--{0}\n--{1:c}\n\n", compo.Name, compo.Price)); /// {0:C} current Currency 
            }

            info.Append(string.Format("Final Price: {0}\n", this.Price));
            info.Append(new String('-', 25) + "\n");


            return info.ToString();
        }

    }
}
