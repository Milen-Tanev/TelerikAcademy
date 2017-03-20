namespace Gsm_Classes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using GSM_Classes;

    public class Gsm
    {

        const decimal pricePerMin = 0.37M;

        private static Gsm iPhone4S = new Gsm("IPhone4S", "Apple", 555.55M, "Pesho",
            new Battery("Detachable",10, 5, BatteryType.Lithium_Ion), new Display(3.5, 16000000));

        private string model;
        private string manufacturer;
        private decimal? price = null;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        //CONSTRUCTORS
        public Gsm(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public Gsm(string model, string manufacturer, decimal price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = null;
            this.Display = null;
        }

        public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //FIELDS
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
                    throw new ArgumentException("Please, enter the model name!");
                }

                else
                {
                    this.model = value;
                }
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
                    throw new ArgumentException("Please, enter the manufacturer's name!");
                }
                this.manufacturer = value;

            }
        }

        public decimal? Price
        {
            get
            {
                return (decimal)this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value must be a positife number");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {            
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public string CallHistory
        {
            get
            {
                if (callHistory.Count == 0)
                {
                    return ("List is empty");
                }

                else
                {
                    StringBuilder callInfo = new StringBuilder();
                    foreach (var item in callHistory)
                    {
                        callInfo.AppendFormat("{0}\n", item);
                    }
                    return callInfo.ToString();
                }
            }
        }

        //No idea if this is correct.
        public static Gsm IPhone4S
        {
            get
            {
                return iPhone4S;
            }

            set
            {
                iPhone4S = value;
            }
        }

        //METHODS
        public void AddCall(string date, string time, string dialledPhone, int callDuration)
        {
            this.callHistory.Add(new Call(date, time, dialledPhone, callDuration));
        }

        public void DeleteCall(int callToDelete)
        {
            if (callToDelete > callHistory.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid call");
            }
            this.callHistory.RemoveAt(callToDelete);
        }

        public void DeleteAllCalls()
        {
            this.callHistory.Clear();
        }

        public void DeleteLongestCall()
        {
            callHistory.Sort((x, y) => x.Duration.CompareTo(y.Duration));
            callHistory.RemoveAt(callHistory.Count - 1);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var item in callHistory)
            {
                totalPrice += item.Duration / 60 * pricePerMin;
            }

            return totalPrice;
        }

        //OVERRIDE
        public override string ToString()
        {
            StringBuilder GsmInfo = new StringBuilder();

            GsmInfo.AppendLine("Model: " + this.model);
            GsmInfo.AppendLine("Manufacurer: " + this.manufacturer);

            if (this.price != null)
            {
                GsmInfo.AppendLine("Price: " + this.price);
            }

            if (this.owner != null)
            {
                GsmInfo.AppendLine("Owner: " + this.owner);
            }

            if (this.battery != null)
            {
                GsmInfo.AppendLine("Battery: " + this.battery);
            }

            if (this.display != null)
            {
                GsmInfo.AppendLine("Display: " + this.display);
            }

            return GsmInfo.ToString();
        }
    }
}