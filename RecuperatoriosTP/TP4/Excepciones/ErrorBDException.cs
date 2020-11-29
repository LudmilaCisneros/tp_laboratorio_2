using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorBDException : Exception
    {
        #region Constructores

        public ErrorBDException(string mensaje): base(mensaje)
        {

        }

        public ErrorBDException(string mensaje, Exception innerException) : base(mensaje,innerException)
        {

        }


        #endregion
    }
}
