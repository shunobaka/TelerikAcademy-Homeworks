namespace MobilePhone
{
    using System;

    class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType typeOfBattery;

        public Battery(string model)
            : this(model, 0, 0, BatteryType.LiIon)
        {
            this.batteryModel = model;
        }

        public Battery(string model, int idle, int talk, BatteryType typeOfBattery)
        {
            this.typeOfBattery = typeOfBattery;
            this.hoursIdle = idle;
            this.hoursTalk = talk;
        }

        public string Model
        {
            get
            {
                return this.batteryModel;
            }
        }

        public string Idle
        {
            get
            {
                if (this.hoursIdle != 0)
                {
                    return this.hoursIdle.ToString();
                }
                else
                {
                    return "None";
                }
            }
        }

        public string Talk
        {
            get
            {
                if (this.hoursTalk != 0)
                {
                    return this.hoursTalk.ToString();
                }
                else
                {
                    return "None";
                }
            }
        }

        public string Type
        {
            get
            {
                return this.typeOfBattery.ToString();
            }
        }
    }
}
