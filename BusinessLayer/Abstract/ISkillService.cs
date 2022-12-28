using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISkillService
    {

        List<MySkill> GetList();

        void MySkillAdd(MySkill myskill);

        MySkill GetByID(int id);

        void MySkillDelete(MySkill myskill);

        void MySkillUpdate(MySkill myskill);
    }
}
