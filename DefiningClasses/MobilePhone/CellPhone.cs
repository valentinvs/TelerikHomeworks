// <copyright file="CellPhone.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace MobilePhone
{
    using System;
    using System.Text;
    using MobilePhone.Enum;

    /// <summary>
    /// Cell Phone
    /// </summary>
    public class CellPhone
    {
        #region Fields
        /// <summary>
        /// The phone 4s
        /// </summary>
        private static CellPhone iphone4S;

        /// <summary>
        /// The model
        /// </summary>
        private string model;

        /// <summary>
        /// The manufacturer
        /// </summary>
        private string manufacturer;

        /// <summary>
        /// The price
        /// </summary>
        private decimal price;

        /// <summary>
        /// The owner
        /// </summary>
        private string owner;

        /// <summary>
        /// The battery
        /// </summary>
        private Battery battery;

        /// <summary>
        /// The display
        /// </summary>
        private Display display;
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes static members of the <see cref="CellPhone"/> class.
        /// </summary>
        static CellPhone()
        {
            Battery battery = new Battery("B2", 168.5f, 80.5f, BatteryType.LiIon);
            Display display = new Display(4.5f, 16700000L);
            iphone4S = new CellPhone("4S", "Apple", 700.50m, "Bai Ivan III", battery, display);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellPhone"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        public CellPhone(string model, string manufacturer)
            : this(model, manufacturer, 0m)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellPhone"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="price">The price.</param>
        public CellPhone(string model, string manufacturer, decimal price)
            : this(model, manufacturer, price, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellPhone"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="price">The price.</param>
        /// <param name="owner">The owner.</param>
        public CellPhone(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellPhone"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="price">The price.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="battery">The battery.</param>
        public CellPhone(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CellPhone"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="price">The price.</param>
        /// <param name="owner">The owner.</param>
        /// <param name="battery">The battery.</param>
        /// <param name="display">The display.</param>
        public CellPhone(string model, string manufacturer, decimal price = 0m, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the i phone4 s.
        /// </summary>
        /// <value>
        /// The i phone4 s.
        /// </value>
        public static CellPhone IPhone4S
        {
            get
            {
                return iphone4S;
            }
        }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        /// <value>
        /// The manufacturer.
        /// </value>
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.manufacturer = value;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        /// <value>
        /// The owner.
        /// </value>
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

        /// <summary>
        /// Gets or sets the battery.
        /// </summary>
        /// <value>
        /// The battery.
        /// </value>
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

        /// <summary>
        /// Gets or sets the display.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
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
        #endregion

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder cellPhoneInfo = new StringBuilder();
            string outerSeparator = new string('=', 40);
            string innerSeparator = new string('-', 40);

            cellPhoneInfo.AppendLine(outerSeparator);
            cellPhoneInfo.AppendLine("Cell Phone Description");
            cellPhoneInfo.AppendLine(outerSeparator);
            cellPhoneInfo.AppendLine("Model: " + this.Model);
            cellPhoneInfo.AppendLine("Manufacturer: " + this.Manufacturer);

            if (this.Price > 0)
            {
                cellPhoneInfo.AppendLine("Price: $" + this.Price);
            }
            else if (this.Price == 0)
            {
                cellPhoneInfo.AppendLine("Price: free");
            }

            if (this.Owner != null)
            {
                cellPhoneInfo.AppendLine("Owner: " + this.Owner);
            }
            else
            {
                cellPhoneInfo.AppendLine("Owner: unknown");
            }

            if (this.Battery != null)
            {
                cellPhoneInfo.AppendLine(Environment.NewLine);
                cellPhoneInfo.AppendLine(this.Battery.ToString());
            }
            else
            {
                cellPhoneInfo.AppendLine("Battery: unknown");
            }

            if (this.Display != null)
            {
                cellPhoneInfo.AppendLine(this.Display.ToString());
            }
            else
            {
                cellPhoneInfo.AppendLine("Display: unknown");
            }

            return cellPhoneInfo.ToString();
        }
    }
}
