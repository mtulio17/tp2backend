using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPN2._3;
using System.Diagnostics;


namespace TPN2._3.Tests

{

   [TestClass]
     public class ElectrodomesticoTests

    {
    [TestMethod]
      public void TestValidarConsumoEnergetico_ValidConsumo_ReturnsMismoConsumo()
    {
        char consumo = 'A';
        Electrodomestico electrodomestico = new Lavadora(200, 10);

        char resultado = electrodomestico.ValidarConsumoEnergetico(consumo);

        Debug.Assert(resultado == consumo, "El consumo no coincide con el esperado.");
    }

    [TestMethod]
    public void TestValidarConsumoEnergetico_InvalidConsumo_ReturnsConsumo()
    {
        char consumo = 'Z';
        Electrodomestico electrodomestico = new Lavadora(200, 10);

        char resultado = electrodomestico.ValidarConsumoEnergetico(consumo);

        Debug.Assert(resultado == 'F', "El consumo no coincide con el esperado.");
    }
    [TestMethod]
    public void TestComprobarColor_ValidColor_ReturnsTrue()
    {
        string color = "NEGRO";
        Electrodomestico electrodomestico = new Lavadora(200, 10);

        bool resultado = electrodomestico.ComprobarColor(color);

        Debug.Assert(resultado, "El color no coincide con el esperado.");
    }
    [TestMethod]
    public void TestComprobarColor_InvalidColor_ReturnsFalse()
    {
        string color = "AMARILLO";
        Electrodomestico electrodomestico = new Lavadora(200, 10);

        bool resultado = electrodomestico.ComprobarColor(color);

        Debug.Assert(!resultado, "El color no coincide con el esperado.");
    }
    [TestMethod]
    public void TestPrecioFinal_LavadoraConCargaMayorA30_Agrega50APrecio()
    {
        Lavadora lavadora = new Lavadora(200, 10, 35, "BLANCO", 'F');

        double resultado = lavadora.PrecioFinal();

        Debug.Assert(resultado == 260, "El precio final no coincide con el esperado.");
    }
    [TestMethod]
    public void TestPrecioFinal_LavadoraConCargaMenorOIguala30_NoAfectaPrecio()
    {
        Lavadora lavadora = new Lavadora(200, 10, 20, "BLANCO", 'F');

        double resultado = lavadora.PrecioFinal();

        Debug.Assert(resultado == 220, "El precio final no coincide con el esperado.");
    }
    [TestMethod]
    public void TestPrecioFinal_TelevisionConResolucionMayora40_Agrega30APrecio()
    {
        Television television = new Television(300, 15, 50, "NEGRO", 'D');

        double resultado = television.PrecioFinal();

        Debug.Assert(resultado == 429, "El precio final no coincide con el esperado.");
    }
    [TestMethod]
    public void TestPrecioFinal_TelevisionConResolucionIgualOMenorA40_NoAfectaPrecio()
    {
        Television television = new Television(300, 15, 32, "NEGRO", 'D');

        double resultado = television.PrecioFinal();

        Debug.Assert(resultado == 300, "El precio final no coincide con el esperado.");
    }
}

}
