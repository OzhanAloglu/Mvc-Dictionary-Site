using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {


        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public MySkill GetByID(int id)
        {
            return _skilldal.Get(x=>x.SkillID== id);
        }

        public List<MySkill> GetList()
        {
            return _skilldal.List();
        }

        public void MySkillAdd(MySkill myskill)
        {
            _skilldal.Insert(myskill);
        }

        public void MySkillDelete(MySkill myskill)
        {
            _skilldal.Delete(myskill);
        }

        public void MySkillUpdate(MySkill myskill)
        {
            _skilldal.Update(myskill);
        }
    }
}
