using ProyectoCodeCraft.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodeCraft.RN
{
    public class RNCargo:Contexto
    {
        DBSITEPEntities Esquema;
        public RNCargo()
        {
            Esquema = this.TraerContexto();
        }
        public List<Cargo> TraerCargo(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Cargo select e).ToList();
            }
            else
            {
                return (from e in Esquema.Cargo where e.Id_Cargo.Equals(id) select e).ToList();
            }
        }
    }
}
