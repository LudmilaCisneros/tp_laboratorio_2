using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        #region Constructores

        public DniInvalidoException(): base("El DNI es invalido.")
        {

        }
        public DniInvalidoException(Exception e) : base("El DNI es invalido.", e)
        {

        }
        public DniInvalidoException(string message) : base(message)
        {
            
        }
        public DniInvalidoException(string message, Exception e) : base(message, e)
        {
            
        }

        #endregion

    }
}

