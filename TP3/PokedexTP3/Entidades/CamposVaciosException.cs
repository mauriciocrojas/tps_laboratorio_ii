using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamposVaciosException : Exception
    {

        public CamposVaciosException(string mensaje) : this(mensaje, null)
        {

        }

        public CamposVaciosException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}