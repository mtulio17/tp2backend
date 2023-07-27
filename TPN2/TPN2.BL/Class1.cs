using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.BL
{

    public class Persona
    {
        // Atributos
        private string nombre;
        private int edad;
        private string DNI;
        private char sexo;
        private double peso;
        private double altura;

        // 
        public Persona()
        {
            // Constructor por defecto
            this.nombre = "";
            this.edad = 0;
            this.DNI = "";
            this.sexo = 'H';
            this.peso = 0.0;
            this.altura = 0.0;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            // Constructor con nombre, edad y sexo
            this.nombre = nombre;
            this.edad = edad;
            validarSexo(sexo);
        }

        public Persona(string nombre, int edad, string DNI, char sexo, double peso, double altura)
        {
            // Constructor con todos los atributos como parámetro
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
            validarSexo(sexo);
            this.peso = peso;
            this.altura = altura;
        }

        // Métodos
        public int CalcularIMC()
        {
            double imc = peso / Math.Pow(altura, 2);

            if (imc < 20)
                return -1;
            else if (imc >= 20 && imc <= 25)
                return 0;
            else
                return 1;
        }

        public bool EsMayorDeEdad()
        {
            return edad >= 18;
        }

        private void validarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M' || sexo == 'N')
                this.sexo = sexo;
            else
                this.sexo = 'H';
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nEdad: {edad}\nDNI: {DNI}\nSexo: {sexo}\nPeso: {peso} kg\nAltura: {altura} m";
        }
    }

}
