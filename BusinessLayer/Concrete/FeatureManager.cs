using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete {
    public class FeatureManager : IGenericService<Feature> {

        IFeatureDal _feetureDal;

        public FeatureManager(IFeatureDal feetureDal) {
            _feetureDal = feetureDal;
        }

        public void TAdd(Feature t) {
            _feetureDal.Insert(t);
        }

        public void TDelete(Feature t) {
            _feetureDal.Delete(t);
        }

        public Feature TGetById(int id) {
            return _feetureDal.GetById(id);
        }

        public List<Feature> TGetList() {
            return _feetureDal.GetList();
        }

        public void TUpdate(Feature t) {
            _feetureDal.Update(t);
        }
    }
}
