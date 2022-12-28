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
    public class AdminManager : IAdminService
    {
        EfAdminDal _admindal;

        public AdminManager(EfAdminDal admindal)
        {
            _admindal = admindal;
        }

        public List<Admin> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
