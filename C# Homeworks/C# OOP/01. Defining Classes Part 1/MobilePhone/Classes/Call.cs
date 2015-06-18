namespace MobilePhone
{
    using System;
    using System.Text;

    class Call
    {
        private string callDate;
        private string callHour;
        private long dialedNumber;
        private int duration;

        public Call(string callDate, string callHour, long dialedNumber, int duration)
        {
            this.callHour = callHour;
            this.callDate = callDate;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public string CallDate
        {
            get
            {
                return this.callDate;
            }
        }

        public string CallHour
        {
            get
            {
                return this.callHour;
            }
        }

        public long Dialed
        {
            get
            {
                return this.dialedNumber;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
        }

        public string CallInfo()
        {
            StringBuilder callInfo = new StringBuilder();

            callInfo.AppendLine("Date of call: " + this.CallDate);
            callInfo.AppendLine("Hour of call: " + this.CallHour);
            callInfo.AppendLine("Dialed number: " + this.Dialed.ToString());
            callInfo.Append("Duration of call: " + this.Duration + " sec");

            return callInfo.ToString();
        }
    }
}
