using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository
{
    /// <summary>
    /// User Department
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.BaseRepository{MyAPITest.Models.UserDepartment}" />
    /// <seealso cref="MyAPITest.Repository.Interfaces.IUserDepartment" />
    public class UserDepartmentRepository: BaseRepository<UserDepartment>, IUserDepartment
    {
        private readonly APIContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDepartmentRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserDepartmentRepository(APIContext context) : base(context)
        {
            _context = context;
        }
    }
}
