using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2._3
{
        public abstract class Electrodomestico
    {
        protected double precioBase;
        protected string color;
        protected char consumoEnergetico;
        protected double peso;

        protected Electrodomestico(double precioBase, string color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        public char ValidarConsumoEnergetico(char letra)
        {
            char[] consumosValidos = { 'A', 'B', 'C', 'D', 'E', 'F' };
            if (Array.IndexOf(consumosValidos, char.ToUpper(letra)) >= 0)
            {
                return char.ToUpper(letra);
            }
            return 'F'; // Por defecto, si el consumo no es válido, se asume F.
        }

        public bool ComprobarColor(string color)
        {
            string[] coloresValidos = { "BLANCO", "NEGRO", "ROJO", "AZUL", "VERDE" };
            return Array.IndexOf(coloresValidos, color.ToUpper()) >= 0;
        }

        public virtual double PrecioFinal()
        {
            double precioConsumo = ObtenerPrecioConsumo(consumoEnergetico);
            double precioPeso = ObtenerPrecioPeso(peso);
            return precioBase + precioConsumo + precioPeso;
        }

        private double ObtenerPrecioConsumo(char consumo)
        {
            switch (char.ToUpper(consumo))
            {
                case 'A': return 100;
                case 'B': return 80;
                case 'C': return 60;
                case 'D': return 50;
                case 'E': return 30;
                default: return 10;
            }
        }

        private double ObtenerPrecioPeso(double peso)
        {
            if (peso >= 0 && peso < 20)
                return 10;
            else if (peso >= 20 && peso < 50)
                return 50;
            else if (peso >= 50 && peso < 80)
                return 80;
            else
                return 100;
        }
    }

    public class Lavadora : Electrodomestico
    {
        private double carga;

        public Lavadora(double precioBase, double peso, double carga, string color, char consumoEnergetico)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public Lavadora(double precioBase, double peso) : this(precioBase, peso, 0, "BLANCO", 'F')
        {
        }

        public Lavadora(double carga) : this(100, 5, carga, "BLANCO", 'F')
        {
        }

        public override double PrecioFinal()
        {
            double precioLavadora = base.PrecioFinal();

            if (carga > 30)
                precioLavadora += 50;

            return precioLavadora;
        }
    }

    public class Television : Electrodomestico
    {
        private int resolucion;

        public Television(double precioBase, double peso, int resolucion, string color, char consumoEnergetico)
            : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
        }

        public Television(double precioBase, double peso) : this(precioBase, peso, 0, "BLANCO", 'F')
        {
        }

        public Television(int resolucion) : this(100, 5, resolucion, "BLANCO", 'F')
        {
        }

        public override double PrecioFinal()
        {
            double precioTelevision = base.PrecioFinal();

            if (resolucion > 40)
                precioTelevision += precioTelevision * 0.3;

            return precioTelevision;
        }
    }

}
