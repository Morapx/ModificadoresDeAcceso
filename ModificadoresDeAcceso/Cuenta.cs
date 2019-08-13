using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Cuenta
    {
        public float saldo { get; set; }
       public string Identificador { get; set; }
          public Cliente Proprietario { get; set; }
        private string _identificador_;
        public string identificador
       


        {
            get
            {
                return _identificador_;
            }
            set
            {
                if (value.Length == 10 || value.Length == 11 || value.Length == 12 || value.Length == 13 || value.Length == 14)
                {
                    _identificador_ = value;
                }
                else
                {
                    throw new Exception("No es de 10 a 14 caracteres");
                }

            }
        }

    
    }
}
