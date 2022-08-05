using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete {
    public class MessageManager : IMessageService {

        IMessageDal _meeesageDal;

        public MessageManager(IMessageDal meeesageDal) {
            _meeesageDal = meeesageDal;
        }

        public void TAdd(Message t) {
            _meeesageDal.Insert(t);
        }

        public void TDelete(Message t) {
            _meeesageDal.Delete(t);
        }

        public Message TGetById(int id) {
           return _meeesageDal.GetById(id);
        }

        public List<Message> TGetList() {
            return _meeesageDal.GetList();
        }

        public void TUpdate(Message t) {
            _meeesageDal.Update(t);
        }
    }
}
