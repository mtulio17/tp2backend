using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPN2.BL;

namespace TPN2.Test
{
    [TestClass]
    public class PersonaTest
    
    {
        public static void Main()
        {
            TestCalcularIMC();
            TestEsMayorDeEdad();
            TestToString();
        }

        // Test de CalcularIMC
        public static void TestCalcularIMC()
        {
            // Arrange
            Persona persona1 = new Persona("Juan", 30, "12345678", 'H', 50.0, 1.70);
            Persona persona2 = new Persona("María", 25, "98765432", 'M', 60.0, 1.70);
            Persona persona3 = new Persona("Carlos", 40, "56789012", 'H', 80.0, 1.70);

            // Act
            int imcResult1 = persona1.CalcularIMC();
            int imcResult2 = persona2.CalcularIMC();
            int imcResult3 = persona3.CalcularIMC();

            // Assert
            Console.WriteLine("Resultado de calcularIMC (esperado: -1): " + imcResult1);
            Console.WriteLine("Resultado de calcularIMC (esperado: 0): " + imcResult2);
            Console.WriteLine("Resultado de calcularIMC (esperado: 1): " + imcResult3);
        }

        // Test de EsMayorDeEdad
        public static void TestEsMayorDeEdad()
        {
            // Arrange
            Persona persona4 = new Persona("Ana", 20, "11223344", 'M', 55.0, 1.65);
            Persona persona5 = new Persona("Pedro", 15, "99887766", 'H', 45.0, 1.60);

            // Act
            bool mayorDeEdadResult1 = persona4.EsMayorDeEdad();
            bool mayorDeEdadResult2 = persona5.EsMayorDeEdad();

            // Assert
            Console.WriteLine("Resultado de esMayorDeEdad (esperado: True): " + mayorDeEdadResult1);
            Console.WriteLine("Resultado de esMayorDeEdad (esperado: False): " + mayorDeEdadResult2);
        }

        // Test de ToString
        public static void TestToString()
        {
            // Arrange
            Persona persona6 = new Persona("Laura", 28, "54321678", 'M', 70.0, 1.75);

            // Act
            string toStringResult = persona6.ToString();

            // Assert
            Console.WriteLine("Resultado de toString:");
            Console.WriteLine(toStringResult);
        }
    }


}
