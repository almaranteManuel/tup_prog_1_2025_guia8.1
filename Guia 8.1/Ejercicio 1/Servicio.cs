using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Servicio
    {
        int acumulador = 0;
        int contador = 0;
        int maximo = 0;
        int minimo = 0;

        public int Maximo
        {
            get { return maximo; }
        }
        public int Minimo
        {
            get { return minimo; }
        }
        public int CantidadNumerosIngresados
        {
            get { return contador; }
        }

        public Servicio()
        {
        }

        public void RegistrarValor(int numero)
        {
            if (contador == 0)
            {
                minimo = numero;
                maximo = numero;
            }
            else
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
            }
            acumulador += numero;
            contador++;
        }

        public double CalcularPromedio()
        {
            if (contador == 0)
            {
                return 0;
            }
            return 1.0*acumulador / contador;
        }
    }
}
