using StarcapModel;
using StarcapModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarcapWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //no viene de una petición POST
            {
                List<Bebida> bebidas = new BebidasDAL().GetAll();
                CafeDdl.DataSource = bebidas;
                //Indica que se va a mostrar en el dropdownlist
                CafeDdl.DataTextField = "Nombre";
                //Indica que se va a obtener en el dropdownlist
                CafeDdl.DataValueField = "Codigo";
                CafeDdl.DataBind();
            }
        }

        protected void rutCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String rut = RutTxt.Text.Trim();
            if (rut == string.Empty)
            {
                //Caso que el rut venga vacío
                RutVal.ErrorMessage = "Debe ingresar el Rut";
                args.IsValid = false;
            }
            else
            {
                // Rut válido es de la forma 12345678-9
                String[] rutArray = rut.Split('-');
                /*
                 * rutArray[0] = 12345678
                 * rutArray[1] = 9
                 */
                if (rutArray.Length == 2)
                {
                    if (rutArray[1].Length != 1)
                    {
                        //Caso que el digito verificador tiene mas de 1 caracter
                        RutVal.ErrorMessage = "El dígito verificador debe tener un caracter";
                        args.IsValid = false;
                    }
                    else
                    {
                        //Caso que cumple formato
                        args.IsValid = true;
                    }
                }
                else
                {
                    //Caso en que rut no tiene un solo guión
                    RutVal.ErrorMessage = "El Rut debe poseer un guión";
                    args.IsValid = false;
                }
            }
        }
}