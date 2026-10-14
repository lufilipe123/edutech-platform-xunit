using EduTechPlatform.App;
using Xunit;

namespace EduTechPlatform.Tests;

public class MatriculaFinanceiraServiceTests
{
    private readonly MatriculaFinanceiraService _service = new();

    [Theory]
    [InlineData(1000.00, 10, true, 500.00)]
    [InlineData(1000.00, 4, false, 900.00)]
    [InlineData(1000.00, 10, false, 1000.00)]
    public void CalcularValorMensalidade_DeveRetornarValorEsperado(
        double valorBase,
        int diaPagamento,
        bool eBolsista,
        double valorEsperado)
    {
        decimal resultado = _service.CalcularValorMensalidade(
            (decimal)valorBase,
            diaPagamento,
            eBolsista);

        Assert.Equal((decimal)valorEsperado, resultado);
    }

    [Theory]
    [InlineData(false, "APROVADO", true)]
    [InlineData(true, "APROVADO", false)]
    [InlineData(false, "REPROVADO", false)]
    public void PodeRealizarRematricula_DeveRetornarResultadoEsperado(
        bool possuiPendenciaFinanceira,
        string situacaoAcademica,
        bool resultadoEsperado)
    {
        bool resultado = _service.PodeRealizarRematricula(
            possuiPendenciaFinanceira,
            situacaoAcademica);

        Assert.Equal(resultadoEsperado, resultado);
    }
}