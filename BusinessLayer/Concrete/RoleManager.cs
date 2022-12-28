using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RoleManager : IRoleService
    {
        EfRoleDal _roledal;

        public RoleManager(EfRoleDal roledal)
        {
            _roledal = roledal;
        }

        public List<Role> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
