using MyAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository.Interfaces
{
    /// <summary>
    /// Department Repository
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.Interfaces.IBaseRepository{MyAPITest.Models.Department}" />
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
    }
}
