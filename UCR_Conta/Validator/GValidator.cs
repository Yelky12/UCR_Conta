using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class GValidator
    {

        double NumTem = 0;



        public Boolean EsNumero(string Num)
        {


            if (double.TryParse(Num, out NumTem))
            { return true; }
            else
            { return false; }
            

        }





        public Boolean EsNegativo(string Num)
        {

            try
            {
                if (double.Parse(Num) >= 0)
                { return false; }
                else
                { return true; }
            }
            catch
            {
                return true;
            }

        }



        public String ValidarCampoNumPositMensaje(string Val)
        {
            string mensaje = "";

            if (!this.EsNumero(Val))
            {
                mensaje = mensaje + "|El dato introducido no es de tipo numero";
            }
            else
            {

                if (this.EsNegativo(Val))
                {
                    mensaje = mensaje + "|No se permiten numeros negativos en este campo";
                }

            }

            return mensaje;
            
        }





    }
}
