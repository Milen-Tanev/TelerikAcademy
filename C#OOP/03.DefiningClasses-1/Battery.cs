namespace Gsm_Classes
{
    using System;
    using System.Text;
    using GSM_Classes;

    public class Battery
    {
        private string batteryModel;
        private int? hoursIdle = null;
        private int? hoursTalk = null;
        private BatteryType batteryType;

        public Battery(string batteryModel, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.BatteryModel = batteryModel;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.TypeBattery = batteryType;
        }
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }

            set
            {
                this.batteryModel = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return (int)this.hoursIdle;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours idle must be a positive integer");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return (int)this.hoursTalk;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours talk must be a positive integer");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType TypeBattery
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder batteryFullInfo = new StringBuilder();
            if (this.batteryModel != null)
            {
                batteryFullInfo.AppendLine("Battery model: " + this.batteryModel);
            }

            if (this.hoursIdle != null)
            {
                batteryFullInfo.AppendLine("Hours idle: " + this.hoursIdle);
            }

            if (this.hoursTalk != null)
            {
                batteryFullInfo.AppendLine("Hours talk: " + this.hoursTalk);
            }

            batteryFullInfo.AppendLine("Battery type: " + this.batteryType);

            return batteryFullInfo.ToString();
        }
    }
}