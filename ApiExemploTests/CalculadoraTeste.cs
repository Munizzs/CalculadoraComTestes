using ApiExemplo.Models;

namespace ApiExemploTests;

public class CalculadoraTeste
{
    private Calculadora _calc;

    public CalculadoraTeste()
    {
        _calc = new Calculadora();
    }
    
    [Theory]
    [InlineData(5,10)]
    public void TesteSomar(int n1,int n2)
    {
        var resultado = _calc.Somar(n1,n2);

        Assert.Equal(15,resultado);
    }

    [Fact]
    public void TesteSubtrair()
    {
        var n1 = 50;
        var n2 = 10;
        var resultadoEsperado = 40;

        var resultado = _calc.Subtrair(n1,n2);

        Assert.Equal(resultadoEsperado,resultado);
    }

    [Fact]
    public void TesteMultiplicar()
    {
        var n1 = 5;
        var n2 = 10;
        var resultadoEsperado = 50;

        var resultado = _calc.Multiplicar(n1,n2);

        Assert.Equal(resultadoEsperado,resultado);
    }

    [Theory]
    [InlineData(10,2,5)]
    public void TesteDividir(int n1, int n2, int res)
    {
        var resultado = _calc.Dividir(n1,n2);

        Assert.Equal(res,resultado);
    }
}