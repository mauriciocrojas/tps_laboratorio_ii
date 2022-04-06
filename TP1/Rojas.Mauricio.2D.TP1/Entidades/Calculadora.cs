using System;

namespace Entidades
{
    public class Calculadora
    {


        //Metodos

        public static double Operar (Operando num1, Operando num2, char operador)
        {
            char signo = ValidarOperador(operador);

            if (signo == '+')
            {
                return num1 + num2;
            }
            
        }

        private static char ValidarOperador (char operador)
        {
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }

            return '+';
        }
    }
}
