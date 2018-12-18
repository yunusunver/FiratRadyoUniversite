using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class RolesManager:IRolesService
    {
        private IRolesDal _rolesDal;
        private IKunyeDal _kunyeDal;

        public RolesManager(IRolesDal rolesDal,IKunyeDal kunyeDal)
        {
            _rolesDal = rolesDal;
            _kunyeDal = kunyeDal;
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
            var bulunanKunye = _kunyeDal.GetList(x => x.RoleId == rolesId).ToList();
            if (bulunanKunye != null)
            {
                foreach (var item in bulunanKunye)
                {
                    _kunyeDal.Delete(item);
                }
            }
            _rolesDal.Delete(new Roles(){Id = rolesId});
        }
    }
}
