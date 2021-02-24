using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public  class Empleado : Persona 
    {
        // ATRIBUTOS
        private string TIPO;
        private string TIPOCONTRATO;
        private double SUELDO;
        private string CEDULAEMPLEADO;
        //PROPIEDADES
        public string TIPO1
        {
            get
            {
                return TIPO;
                           }

            set
            {
                TIPO = value;
            }
        }

        public string TIPOCONTRATO1
        {
            get
            {
                return TIPOCONTRATO;
            }

            set
            {
                TIPOCONTRATO = value;
            }
        }

        public double SUELDO1
        {
            get
            {
                return SUELDO;
            }

            set
            {
                SUELDO = value;
            }
        }

        public string CEDULAEMPLEADO1
        {
            get
            {
                return CEDULAEMPLEADO;
            }

            set
            {
                CEDULAEMPLEADO = value;
            }
        }

        //PROCEDIMIENTO, OPERACIONES O METODOS
        public void CALCULARSUELDO(double SUELDOBASE)
        {            
                if (this.TIPOCONTRATO1 == "Nuevo")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "Longevo")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;
                }               
            else
            {
                this.SUELDO1 = 0;
            }
        }
        public void GENERARLISTADECEDULA()
        {
            this.CEDULAEMPLEADO1 = "ID" + this.CEDULAEMPLEADO1.Substring(0, 10);
        }
    }
}
