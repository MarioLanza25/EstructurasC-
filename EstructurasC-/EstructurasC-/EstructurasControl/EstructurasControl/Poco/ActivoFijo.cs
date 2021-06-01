using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasControl.Poco
{
    class ActivoFijo
    {

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public decimal ValorActivo { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public decimal ValorResidual { get; set; }
        //public String Codigo
        //{
        //    get
        //    {
        //        return codigo;

        //    }
        //    set
        //    {
        //        codigo = value;
        //    }
        //}

        ////Forma corta de metodos de acceso
        //public String Nombre
        //{
        //    get => nombre;  //Operador de expresiones
        //    set => nombre = value;
    
    }
}
