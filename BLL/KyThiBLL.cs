using System;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class KyThiBLL
    {
        private readonly KyThiDAL _dal = new KyThiDAL();

        public List<KyThi> GetAll(string trangThaiFilter = null)
        {
           return _dal.GetAll(trangThaiFilter);
        }

        public KyThi GetById(int id) => _dal.GetById(id);

        public void Create(KyThi kyThi)
        {
            _dal.Add(kyThi);
        }

        public void Update(KyThi kyThi)
        {
            _dal.Update(kyThi);
        }

        public List<KetQuaThi> GetParticipants(int kyThiId) => _dal.GetParticipants(kyThiId);
    }
}