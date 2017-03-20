namespace GSM_Classes
{
    using System.Text;

    class Call
    {
        private string date;
        private string time;
        private string dialledPhone;
        private int duration;

        public Call(string date, string time, string dialledPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }

        public string Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public string Time
        {
            get
            {
                return this.time;
            }

            set
            {
                this.time = value;
            }
        }

        public string DialledPhone
        {
            get
            {
                return this.dialledPhone;
            }

            set
            {
                this.dialledPhone = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            StringBuilder calls = new StringBuilder();
            calls.AppendFormat("Date: {0}, Time: {1}, Phone number: {2}, Duration: {3}", this.Date, this.Time, this.DialledPhone, this.Duration);
            return calls.ToString();
        }
    }
}