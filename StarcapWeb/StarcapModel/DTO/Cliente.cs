using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcapModel
{
   public partial class Cliente
    {
        private String rut;
        private String nombre;
        private int nivel;
        private String codigoBebida;

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }

        public string CodigoBebida
        {
            get
            {
                return codigoBebida;
            }

            set
            {
                codigoBebida = value;
            }
        }
    }
}
