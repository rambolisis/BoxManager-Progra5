using System;
using System.Collections.Generic;

namespace BoxManager.BS.Models
{
    public class WodModel
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public int Nivel { get; set; }

        public int TipoConteo { get; set; }

        public int IdTenant { get; set; }

        public string ReturnUrl { get; set; }

        public List<NivelModel> Niveles { get; set; }

        public List<TipoConteoModel> TiposConteo { get; set; }
    }
}
