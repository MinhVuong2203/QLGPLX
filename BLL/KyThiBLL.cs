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

        public int GetRegisteredCount(int kyThiId) => new KyThiDAL().GetDistinctParticipantCount(kyThiId);

        public List<HoSo> GetPendingHoSoForKyThi(int kyThiId) => _dal.GetPendingHoSoForKyThi(kyThiId);

        public void AddParticipant(int kyThiId, int hoSoId) => _dal.AddParticipant(kyThiId, hoSoId);
        public void RemoveParticipant(int kyThiId, int hoSoId) => _dal.RemoveParticipant(kyThiId, hoSoId);
        public bool RetryParticipant(int kyThiId, int hoSoId) => _dal.RetryParticipant(kyThiId, hoSoId);

    }
}