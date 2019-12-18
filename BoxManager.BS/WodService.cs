using BoxManager.BS.Models;
using BoxManager.DAL;

namespace BoxManager.BS
{
    public class WodService
    {
        public void Insert(WodModel model)
        {
            var wodDAL = new WodDAL();

            var wod = new wod()
            {
                fecha = model.Fecha,
                nivel = model.Nivel,
                descripcion = model.Descripcion,
                tipoConteo = model.TipoConteo,
                idTenant = model.IdTenant
            };

            wodDAL.Insert(wod);
        }
    }
}
