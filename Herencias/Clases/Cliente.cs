using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public  class Cliente : Persona 
    {
        //ATRIBUTOS 
        private string CATEGORIA;
        private string CODIGODEPEDIDO;
        private string CEDULACLIENTE;

        public string CATEGORIA1
        {
            get
            {
                return CATEGORIA;
            }

            set
            {
                CATEGORIA = value;
            }
        }

        public string CODIGODEPEDIDO1
        {
            get
            {
                return CODIGODEPEDIDO;
            }

            set
            {
                CODIGODEPEDIDO = value;
            }
        }

        public string CEDULACLIENTE1
        {
            get
            {
                return CEDULACLIENTE;
            }

            set
            {
                CEDULACLIENTE = value;
            }
        }

        //PROCEDIMIENTOS, OPERACIONES O METODOS
        public void GENERARCODIGODEPEDIDO()
        {
            this.CODIGODEPEDIDO1 = "C" + this.APPAPATERNO1.Substring(0, 3);
        }
    }
}
