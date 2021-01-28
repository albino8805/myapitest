using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Models
{
    /// <summary>
    /// UserDeparment entity
    /// </summary>
    public class UserDepartment: BaseEntity
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        /// <summary>
        /// Gets or sets the deparment identifier.
        /// </summary>
        /// <value>
        /// The deparment identifier.
        /// </value>
        [Required]
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual User User { get; set; }
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public virtual Department Department { get; set; }
    }
}
