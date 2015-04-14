namespace MobilePhone
{
    using System;

    class Display
    {
        private int size;
        private int numberOfColors;

        public Display()
        {

        }

        public Display(int size)
            : this()
        {
            this.size = size;
        }

        public Display(int size, int numberOfColors)
            : this()
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public string Size
        {
            get
            {
                if (this.size != 0)
                {
                    return this.size.ToString();
                }
                else
                {
                    return "Not specified";
                }
            }
        }

        public string NumberOfColors
        {
            get
            {
                if (this.numberOfColors != 0)
                {
                    return this.numberOfColors.ToString();
                }
                else
                {
                    return "Not specified";
                }
            }
        }
    }
}
