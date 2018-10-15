using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class RolesManager:IRolesService
    {
        private IRolesDal _rolesDal;

        public RolesManager(IRolesDal rolesDal)
        {
            _rolesDal = rolesDal;
        }

        public Roles Get(int id)
        {
            return _rolesDal.Get(x => x.Id == id);
        }
        public List<Roles> GetAll()
        {
            return _rolesDal.GetList();
        }

        public void Add(Roles roles)
        {
            _rolesDal.Add(roles);
        }

        public void Update(Roles roles)
        {
            _rolesDal.Update(roles);
        }

        public void Delete(int rolesId)
        {
            _rolesDal.Delete(new Roles(){Id = rolesId});
        }
    }
}
