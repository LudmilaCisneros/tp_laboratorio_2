using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        #region Constructores
        public NacionalidadInvalidaException() : this("La nacionalidad no es válida para el DNI")
        {

        }
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }
        #endregion
    }
}
