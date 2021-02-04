using MyAPITest.Models;
using MyAPITest.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository
{
    /// <summary>
    /// UserRepository
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.Interfaces.IUserRepository" />
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        private readonly APIContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public UserRepository(APIContext context): base(context)
        {
            _context = context;
        }        
    }
}
