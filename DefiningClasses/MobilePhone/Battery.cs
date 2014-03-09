// <copyright file="Battery.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace MobilePhone
{
    using System.Text;
    using MobilePhone.Enum;

    /// <summary>
    /// Battery class
    /// </summary>
    public class Battery
    {
        /// <summary>
        /// The model
        /// </summary>
        private string model;

        /// <summary>
        /// The hours idle
        /// </summary>
        private float hoursIdle;

        /// <summary>
        /// The hours talk
        /// </summary>
        private float hoursTalk;

        /// <summary>
        /// The battery type
        /// </summary>
        private BatteryType batteryType;

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public Battery(string model)
            : this(model, 0f)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="hoursIdle">The hours idle.</param>
        public Battery(string model, float hoursIdle)
            : this(model, hoursIdle, 0f)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="hoursIdle">The hours idle.</param>
        /// <param name="hoursTalk">The hours talk.</param>
        public Battery(string model, float hoursIdle, float hoursTalk)
            : this(model, hoursIdle, hoursTalk, BatteryType.Unknown)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Battery"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="hoursIdle">The hours idle.</param>
        /// <param name="hoursTalk">The hours talk.</param>
        /// <param name="batteryType">Type of the battery.</param>
        public Battery(string model, float hoursIdle, float hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.BatteryType = batteryType;
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
        /// Gets or sets the hours idle.
        /// </summary>
        /// <value>
        /// The hours idle.
        /// </value>
        public float HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                this.hoursIdle = value;
            }
        }

        /// <summary>
        /// Gets or sets the hours talk.
        /// </summary>
        /// <value>
        /// The hours talk.
        /// </value>
        public float HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                this.hoursTalk = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the battery.
        /// </summary>
        /// <value>
        /// The type of the battery.
        /// </value>
        public BatteryType BatteryType
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

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder batteryInfo = new StringBuilder();

            batteryInfo.AppendLine("Battery Description");
            batteryInfo.AppendLine("Model: " + this.Model);

            if (this.HoursIdle != 0f)
            {
                batteryInfo.AppendLine("Hours idle: " + this.HoursIdle);
            }
            else
            {
                batteryInfo.AppendLine("Hours idle: unknown");
            }

            if (this.HoursTalk != 0f)
            {
                batteryInfo.AppendLine("Hours talk: " + this.HoursTalk);
            }
            else
            {
                batteryInfo.AppendLine("Hours talk: unknown");
            }

            if (this.BatteryType != BatteryType.Unknown)
            {
                batteryInfo.AppendLine("Battery type: " + this.BatteryType.ToString());
            }
            else
            {
                batteryInfo.AppendLine("battery type: unknown");
            }

            return batteryInfo.ToString();
        }
    }
}
