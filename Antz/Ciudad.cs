//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Antz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ciudad
    {
        public Ciudad()
        {
            this.Vecinos = new HashSet<Vecinos>();
        }
    
        public int idCiudad { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Vecinos> Vecinos { get; set; }
        public virtual Vecinos Vecino { get; set; }
    }
}
