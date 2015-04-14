namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        private Battery battery;
        private Display display;
        private string phoneModel;
        private string manufacturer;
        private int phonePrice;
        private string phoneOwner;
        private List<Call> callHistory = new List<Call>();

        private const decimal pricePerMinute = 0.37M;

        private static readonly GSM iphone4s = new GSM("iPhone 4S", "Apple", 485, "Peter",
            new Battery("Non-removable", 300, 200, BatteryType.LiIon),
            new Display(3, 16000000));

        public GSM(string phoneModel, string manufacturer)
        {
            this.phoneModel = phoneModel;
            this.manufacturer = manufacturer;
        }

        public GSM(string phoneModel, string manufacturer, Battery battery, Display display)
            : this(phoneModel, manufacturer)
        {
            this.battery = battery;
            this.display = display;
        }

        public GSM(string phoneModel, string manufacturer, int phonePrice, string phoneOwner, Battery battery, Display display)
            : this(phoneModel, manufacturer, battery, display)
        {
            this.phonePrice = phonePrice;
            this.phoneOwner = phoneOwner;
        }

        public string Price
        {
            get
            {
                if (this.phonePrice != 0)
                {
                    return this.phonePrice.ToString();
                }
                else
                {
                    return "unknown";
                }
            }
        }

        public string Owner
        {
            get
            {
                if (this.phoneOwner != null && this.phoneOwner != string.Empty)
                {
                    return this.phoneOwner;
                }
                else
                {
                    return "no owner";
                }
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iphone4s;
            }
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                callHistory.RemoveAt(index);
            }
        }

        public string CallPrice()
        {
            decimal price = new decimal();

            foreach (var call in this.callHistory)
            {
                price += call.Duration;
            }
            price /= 60;
            price *= pricePerMinute;
            string result = "Total price of calls: " + price.ToString("C");
            return result;
        }

        public void DeleteHistory()
        {
            this.callHistory.Clear();
        }

        public string PrintCalls()
        {
            StringBuilder callInfo = new StringBuilder();

            for (int i = 0; i < callHistory.Count; i++)
            {
                if (i != callHistory.Count - 1)
                {
                    callInfo.AppendLine("Call number: " + (i + 1));
                    callInfo.AppendLine(callHistory[i].CallInfo());
                    callInfo.AppendLine();
                }
                else
                {
                    callInfo.AppendLine("Call number: " + (i + 1));
                    callInfo.Append(callHistory[i].CallInfo());
                }
            }

            return callInfo.ToString();
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            information.AppendLine("Manufacturer: " + this.manufacturer);
            information.AppendLine("Phone model: " + this.phoneModel);
            information.AppendLine("Price: " + this.Price);
            information.AppendLine("Owner: " + this.Owner);
            if (display != null)
            {
                information.AppendLine("Display size: " + this.display.Size);
                information.AppendLine("Number of colors: " + this.display.NumberOfColors);
            }
            if (battery != null)
            {
                information.AppendLine("Battery model: " + this.battery.Model);
                information.AppendLine("Battery type: " + this.battery.Type);
                information.AppendLine("Stand-by time: " + this.battery.Idle);
                information.AppendLine("Talking time: " + this.battery.Talk);
            }
            return information.ToString();
        }
    }
}
