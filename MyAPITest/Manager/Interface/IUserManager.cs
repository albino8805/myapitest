using MyAPITest.Models;
using MyAPITest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Manager.Interface
{
    /// <summary>
    /// IUserManager
    /// </summary>
    public interface IUserManager: IBaseManager<User, UserViewModel>
    {
    }
}
