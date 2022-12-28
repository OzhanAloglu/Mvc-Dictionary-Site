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
    public class ContactManager : IContactService
    {

        IContactDal _ıcontactdal;

        public ContactManager(IContactDal ıcontactdal)
        {
            _ıcontactdal = ıcontactdal;
        }

        public void ContactAdd(Contact contact)
        {
            _ıcontactdal.Insert(contact);
        }

        public void ContactDelete(Contact contact)
        {
            _ıcontactdal.Delete(contact);
        }

        public void ContactUpdate(Contact contact)
        {
            _ıcontactdal.Update(contact);
        }

        public Contact GetByID(int id)
        {
            return _ıcontactdal.Get(x => x.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _ıcontactdal.List();
        }
    }
}
