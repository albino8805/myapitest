using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Models
{
    /// <summary>
    /// APIContext
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class APIContext: DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>
        /// The user.
        /// </value>
        public virtual DbSet<User> User { get; set; }
        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        /// <value>
        /// The department.
        /// </value>
        public virtual DbSet<Department> Department { get; set; }
        /// <summary>
        /// Gets or sets the user department.
        /// </summary>
        /// <value>
        /// The user department.
        /// </value>
        public virtual DbSet<UserDepartment> UserDepartment { get; set; }
    }
}
