using Xunit;
using ConcecionariaDoDev;

namespace TesteSolution.Teste;

public class ClienteTeste
{
    [Fact]
    public void TesteFuncionalidadeDeGetSetTelefone()
    {
        var valorEsperado = "Sidney";
        var cliente = new Cliente(valorEsperado, "55454887", "11/10/2021");
        var valorAtual = pessoa.GetNome();
        Assert.Equal(valorEsperado, valorAtual);
    }
}