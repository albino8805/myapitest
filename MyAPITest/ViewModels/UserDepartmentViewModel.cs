using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.ViewModels
{
    /// <summary>
    /// UserDepartmentViewModel
    /// </summary>
    /// <seealso cref="MyAPITest.ViewModels.BaseViewModel" />
    public class UserDepartmentViewModel: BaseViewModel
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentId { get; set; }
    }
}
