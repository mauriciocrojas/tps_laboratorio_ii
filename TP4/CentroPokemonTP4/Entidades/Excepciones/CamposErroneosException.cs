using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposErroneosException : Exception
    {

        public CamposErroneosException(string mensaje) : this(mensaje, null)
        {

        }

        public CamposErroneosException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}