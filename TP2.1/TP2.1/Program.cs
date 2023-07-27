using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2._1;

namespace TP2._1
{
    using System;

    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        // Constructor que recibe dos parámetros
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // Constructor que recibe un parámetro opcional
        public Cuenta(string titular)
        {
            this.titular = titular;
           
        }

        // Método para depositar
        public void Deposito(decimal cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }

        // Método para retirar
        public void Retiro(decimal cantidad)
        {
            if (cantidad > 0)
            {
                if (cantidad <= this.cantidad)
                {
                    this.cantidad -= cantidad;
                }
                else
                {
                    this.cantidad = 0;
                }
            }
        }

        // Método saldo actual de la cuenta
        public decimal SaldoActual()
        {
            return cantidad;
        }
    }
}


public class Program
{
    public static void Main()
    {
      
        Cuenta cuenta1 = new Cuenta("Juan", 1000);
        Cuenta cuenta2 = new Cuenta("María");

        Console.WriteLine("Saldo cuenta1: " + cuenta1.SaldoActual()); // Saldo cuenta1: 1000
        Console.WriteLine("Saldo cuenta2: " + cuenta2.SaldoActual()); // Saldo cuenta2: 0
        Console.ReadLine();

        cuenta1.Deposito(500);
        cuenta2.Deposito(200);

        Console.WriteLine("Saldo cuenta1 después del depósito: " + cuenta1.SaldoActual()); // Saldo cuenta1 después del depósito: 1500
        Console.WriteLine("Saldo cuenta2 después del depósito: " + cuenta2.SaldoActual()); // Saldo cuenta2 después del depósito: 200
        Console.ReadLine();

        cuenta1.Retiro(2000);
        cuenta2.Retiro(100);

        Console.WriteLine("Saldo cuenta1 después del retiro: " + cuenta1.SaldoActual()); // Saldo cuenta1 después del retiro: 0
        Console.WriteLine("Saldo cuenta2 después del retiro: " + cuenta2.SaldoActual()); // Saldo cuenta2 después del retiro: 100
        Console.ReadLine();
        cuenta1.Deposito(-500);
        cuenta2.Retiro(-100);
        Console.ReadLine();

        Console.WriteLine("Saldo cuenta1 después de intentar depósito negativo: " + cuenta1.SaldoActual()); // Saldo cuenta1 después de intentar depósito negativo: 0
        Console.WriteLine("Saldo cuenta2 después de intentar retiro negativo: " + cuenta2.SaldoActual()); // Saldo cuenta2 después de intentar retiro negativo: 100
        Console.ReadLine();
    }
}
