using BoxManager.BS.Models;
using BoxManager.DAL;
using System.Collections.Generic;

namespace BoxManager.BS
{
    public class NivelService
    {
        public List<NivelModel> GetByTenantId(int tenantIdId)
        {
            var nivelesDAL = new NivelDAL();
            var nivelesEntities = nivelesDAL.GetAll(tenantIdId);

            var niveles = new List<NivelModel>();
            foreach(var nivel in nivelesEntities)
            {
                niveles.Add(new NivelModel()
                {
                    Id = nivel.id,
                    Nombre = nivel.nombre,
                    TenantId = nivel.idTenant
                });
            }

            return niveles;
        }
    }
}
