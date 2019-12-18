using BoxManager.BS.Models;
using BoxManager.DAL;
using System.Collections.Generic;

namespace BoxManager.BS
{
    public class TipoConteoService
    {
        public List<TipoConteoModel> GetByTenantId(int tenantIdId)
        {
            var tipoConteoDAL = new TipoConteoDAL();
            var tiposConteoEntities = tipoConteoDAL.GetAll(tenantIdId);

            var tiposConteo = new List<TipoConteoModel>();
            foreach (var tipoConteo in tiposConteoEntities)
            {
                tiposConteo.Add(new TipoConteoModel()
                {
                    Id = tipoConteo.id,
                    Nombre = tipoConteo.nombre,
                    TenantId = tipoConteo.idTenant
                });
            }

            return tiposConteo;
        }
    }
}
