//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoCodeCraft.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class VistaEmpleadoCargo
    {
        public long Id_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Carnet_Identidad { get; set; }
        public System.DateTime Fecha_Nacimiento { get; set; }
        public long IdCargo { get; set; }
        public long Id_Cargo { get; set; }
        public string Nombre_Cargo { get; set; }
        public string Descripcion { get; set; }
    }
}