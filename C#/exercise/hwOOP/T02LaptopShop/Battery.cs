using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02LaptopShop
{
    public class Battery
    {
        private string batteryModel = null;
        private int batteryLife = 0;

        public Battery(string batteryModel, int batteryLife)
        {
            this.BatteryModel = batteryModel;
            this.BatteryLife = batteryLife;
        }

        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Must have some name !");
                }

                this.batteryModel = value;
            }
        }

        public int BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Must be a positive number !");
                }

                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string batteryInfo = string.Empty;

            if (!string.IsNullOrEmpty(this.batteryModel))
            {
                batteryInfo += string.Format("Battery model : {0}\n", this.batteryModel);
            }
            if (this.batteryLife > 0)
            {
                batteryInfo += string.Format("Battery life : {0} hours\n", this.batteryLife);
            }

            return batteryInfo;
        }  
        
    }
}
