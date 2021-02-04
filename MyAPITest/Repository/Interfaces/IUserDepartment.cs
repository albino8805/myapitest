using MyAPITest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Repository.Interfaces
{
    /// <summary>
    /// User Department
    /// </summary>
    /// <seealso cref="MyAPITest.Repository.Interfaces.IBaseRepository{MyAPITest.Models.UserDepartment}" />
    public interface IUserDepartment: IBaseRepository<UserDepartment>
    {
    }
}
