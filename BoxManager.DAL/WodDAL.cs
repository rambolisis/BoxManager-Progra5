using BoxManager.DO.Interfaces;
using System;
using System.Collections.Generic;

namespace BoxManager.DAL
{
    public class WodDAL : ICRUD<wod>, IGetAll<wod>
    {
        public void Delete(wod entity)
        {
            throw new NotImplementedException();
        }

        public List<wod> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(wod entity)
        {
            using (var entities = new BoxManagerEntities())
            {
                entities.wods.Add(entity);
                entities.SaveChanges();
            }
        }

        public void Update(wod entity)
        {
            throw new NotImplementedException();
        }
    }
}
