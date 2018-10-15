using System;
using System.Collections.Generic;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Abstract
{
    public interface IRolesService
    {
        Roles Get(int id);
        List<Roles> GetAll();
        void Add(Roles roles);
        void Update(Roles roles);
        void Delete(int rolesId);
    }
}
