namespace Entidades
{
    public class Operando
    {
        private double numero;

        private Operando()
        {
            numero = 0;
        }

        //Metodos

        private double ValidarOperando(string strNumero)
        {
            if (int.TryParse(strNumero, out int auxDouble))
            {
                return auxDouble;
            }
            return 0;
        }

        // Setea valor del numero
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        // Comprueba que el string pasado sea un numero binario, retorna false si no lo es, true si lo es
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


    }
}
