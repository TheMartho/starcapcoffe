using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcapModel.DAL
{
    public class BebidasDAL
    {
        private static List<Bebida> bebidas = new List<Bebida>()
        {
            new Bebida()
            {
                Nombre="Frapuchino",
                Codigo="F-01",
            },
             new Bebida()
            {
                Nombre="Café",
                Codigo="C-01",
            },
            new Bebida()
            {
                Nombre="Té",
                Codigo="T-01",
            },
            new Bebida()
            {
                Nombre="Té Chai",
                Codigo="T-02",
            }
        };

        public List<Bebida> GetAll()
        {
            return bebidas;
        }
    }
}
