﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCodeCraft.Datos
{
    public class Contexto
    {
        public DBSITEPEntities TraerContexto()
        {
            DBSITEPEntities AuxCont = new DBSITEPEntities();
            return AuxCont;
        }
    }
}
