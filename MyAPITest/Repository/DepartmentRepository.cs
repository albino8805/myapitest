using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository
{
    /// <summary>
    /// Department Repository
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.BaseRepository{MyAPITest.Models.Department}" />
    /// <seealso cref="MyAPITest.Repository.Interfaces.IDepartmentRepository" />
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly APIContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DepartmentRepository(APIContext context) : base(context)
        {
            _context = context;
        }
    }
}
