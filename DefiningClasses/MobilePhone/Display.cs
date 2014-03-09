// <copyright file="Display.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace MobilePhone
{
    using System.Text;

    /// <summary>
    /// Display class
    /// </summary>
    public class Display
    {
        /// <summary>
        /// The size
        /// </summary>
        private float size;

        /// <summary>
        /// The colors count
        /// </summary>
        private long colorsCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Display"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="colorsCount">The colors count.</param>
        public Display(float size, long colorsCount)
        {
            this.Size = size;
            this.ColorsCount = colorsCount;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public float Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        /// <summary>
        /// Gets or sets the colors count.
        /// </summary>
        /// <value>
        /// The colors count.
        /// </value>
        public long ColorsCount
        {
            get
            {
                return this.colorsCount;
            }

            set
            {
                this.colorsCount = value;
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
            StringBuilder displayInfo = new StringBuilder();

            displayInfo.AppendLine("Display Description");
            displayInfo.AppendLine("Size: " + this.Size);
            displayInfo.AppendLine("Colors: " + this.ColorsCount);

            return displayInfo.ToString();
        }
    }
}
