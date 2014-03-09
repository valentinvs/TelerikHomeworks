// <copyright file="MobilePhoneApp.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace MobilePhoneApp
{
    using System;
    using MobilePhone;
    using MobilePhone.Enum;

    /// <summary>
    /// Console Application
    /// </summary>
    public class MobilePhoneApp
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static void Main()
        {
            Battery nokiaBattery = new Battery("B2", 168.5f, 80.5f, BatteryType.NiMH);
            Display nokiaDisplay = new Display(4.5f, 16700000L);
            CellPhone nokia = new CellPhone("C3", "Nokia", 100m, "Ivan Ivanov", nokiaBattery, nokiaDisplay);
            Console.WriteLine(nokia);

            Display galaxyDisplay = new Display(5.5f, 16700000L);
            CellPhone galaxy = new CellPhone("S3", "Galaxy", display: galaxyDisplay);
            Console.WriteLine(galaxy);

            CellPhone cheapPhone = new CellPhone("cheap", "china phones");
            Console.WriteLine(cheapPhone);

            Console.WriteLine(CellPhone.IPhone4S);
        }
    }
}
