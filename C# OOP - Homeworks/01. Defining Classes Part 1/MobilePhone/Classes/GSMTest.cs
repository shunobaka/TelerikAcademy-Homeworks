namespace MobilePhone
{
    using System;

    class GSMTest
    {
        private static GSM[] phones = new GSM[]
        {
            new GSM("Lumia", "Nokia", 3000, "Pesho", new Battery("Gosho"), new Display(13)),
            new GSM("530", "Sony Erricson", new Battery("Cool Battery"),new Display()),
            new GSM("coolModel", "Pesho", new Battery("GoshoBattery"), new Display(20, 2300000)),
            new GSM("iPhone 6 Plus", "Apple"),
        };

        public static GSM[] Phones
        {
            get
            {
                return phones;
            }
        }
    }
}
