using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Theory]
    [InlineData(1, 2 , 3)]
    [InlineData(4, 5, 9)]
    public void DeveSomarERetornaroResultadoEsperado(int valor1, int valor2, int resultado)
    {
        int resultadoCalculadora = _calc.Somar(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 2, 0)]
    [InlineData(9, 5, 4)]
    public void DeveSubtrairERetornaroResultadoEsperado(int valor1, int valor2, int resultado)
    {
        int resultadoCalculadora = _calc.Subtrair(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(5, 2, 10)]
    [InlineData(9, 5, 45)]
    public void DeveMultiplicarERetornaroResultadoEsperado(int valor1, int valor2, int resultado)
    {
        int resultadoCalculadora = _calc.Multiplicar(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(8, 4, 2)]
    public void DeveDividirERetornaroResultadoEsperado(int valor1, int valor2, int resultado)
    {
        int resultadoCalculadora = _calc.Dividir(valor1, valor2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1, 3);
        _calc.Somar(5, 7);
        _calc.Somar(1, 12);
        _calc.Somar(33, 11);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}