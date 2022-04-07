using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        private Operando()
        {
            numero = 0;
        }


        public Operando (double numero) : this()
        {
            this.numero = numero;
        }

        public Operando (string strNumero) : this()
        {
            Numero = strNumero;
        }

        //Metodos

        /// <summary>
        /// Valida que el parámetro pasado pueda convertirse en un entero
        /// </summary>
        /// <param name="strNumero">Parámetro a evaluar</param>
        /// <returns>Valor entero tipo double</returns>
        private double ValidarOperando(string strNumero)
        {
            if (int.TryParse(strNumero, out int auxDouble))
            {
                return auxDouble;
            }
            return 0;
        }

        /// <summary>
        /// Propiedad que setea this.numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        ///Comprueba que el string pasado sea un numero binario, retorna false si no lo es, true si lo es
        /// </summary>
        /// <param name="binario">Cadena a recorrer</param>
        /// <returns>True o False acorde a si es o no binario</returns>
        private bool EsBinario(string binario)
        {

            for (int i = 0; i < binario.Length - 1; i++)
            {
                if (binario[i] == '0' || binario[i] == '1')
                {
                    return true;
                }
            }

            return false;
        }

        // Convierte el numero binario a un decimal, retornara "Valor Invalido" en caso que el numero ingresado no sea binario
        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {

                int cont = 0;
                double resultado = 0;

                for (int i = binario.Length - 1; i > -1; i--)
                {

                    if (binario[i] == '1')
                    {
                        resultado += Math.Pow(2, cont);
                    }
                    cont++;
                }

                return Convert.ToString(resultado);
            }
            else
            {
                return "Valor invalido";
            }
        }


        /// <summary>
        /// Convierte un decimal a binario y lo retorna como string, sino retornara "Valor invalido" 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            if (numero > -1)
            {
                string total = string.Empty;
                string aux = string.Empty;
                while ((int)numero > 0)
                {
                    aux += Convert.ToString(((int)(numero % 2)));
                    numero = numero / 2;
                }

                for (int i = aux.Length - 1; i > -1; i--)
                {
                    total += aux[i];
                }

                return Convert.ToString(total);
            }

            return "Valor invalido";
        }


        /// <summary>
        /// Transforma un string a un decimal, luego a binario
        /// </summary>
        /// <param name="numero">Numero decimal a transformar a binario</param>
        /// <returns>Valor en binario en formato string o mensaje de error</returns>
        public string DecimalBinario(string numero)
        {
            double numeroATranformar;
            if (double.TryParse(numero, out numeroATranformar))
            {
                return DecimalBinario(numeroATranformar);
            }
            else
            {
                return "Valor invalido";
            }

        }


        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            return n1.numero / n2.numero;
        }
    }
}
