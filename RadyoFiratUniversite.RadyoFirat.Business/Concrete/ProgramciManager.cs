using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RadyoFiratUniversite.RadyoFirat.Business.Abstract;
using RadyoFiratUniversite.RadyoFirat.DataAccess.Abstract;
using RadyoFiratUniversite.RadyoFirat.Entities.Concrete;

namespace RadyoFiratUniversite.RadyoFirat.Business.Concrete
{
    public class ProgramciManager:IProgramciService
    {
        private IProgramciDal _programciDal;

        public ProgramciManager(IProgramciDal programciDal)
        {
            _programciDal = programciDal;
        }

        public Programci Get(int id)
        {
            return _programciDal.Get(x=>x.Id==id);
        }

        public List<Programci> GetAll()
        {
            return _programciDal.GetList();
        }

        public List<Programci> GetListByCreatedDate(DateTime createdDate)
        {
            return _programciDal.GetList().OrderByDescending(x => x.CreatedDate).ToList();
        }

        public void Add(Programci programci)
        {
            programci.CreatedDate=DateTime.Now;
            _programciDal.Add(programci);
        }

        public void Update(Programci programci)
        {
            
            _programciDal.Update(programci);
        }

        public void Delete(int programciId)
        {
            _programciDal.Delete(new Programci(){Id = programciId});
        }
    }
}
