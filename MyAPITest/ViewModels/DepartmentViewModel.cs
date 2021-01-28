using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.ViewModels
{
    /// <summary>
    /// DepartmentViewModel
    /// </summary>
    public class DepartmentViewModel : BaseViewModel
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public int Level { get; set; }
        /// <summary>
        /// Gets or sets the bedrooms.
        /// </summary>
        /// <value>
        /// The bedrooms.
        /// </value>
        public int Bedrooms { get; set; }
    }
}
