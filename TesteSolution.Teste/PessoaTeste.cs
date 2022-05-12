using Xunit;
using ConcecionariaDoDev;

namespace TesteSolution.Teste;

public class PessoaTeste
{
    [Fact]
    public void TesteFuncionalidadeDeGetSetNome()
    {
        var valorEsperado = "Sidney";
        var pessoa = new Pessoa(valorEsperado, "55454887", "11/10/2021");
        var valorAtual = pessoa.GetNome();
        Assert.Equal(valorEsperado, valorAtual);        
    }
    [Fact]
    public void TesteFuncionalidadeDeGetSetCpf()
    {
        var valorEsperado = "55454887";
        var pessoa = new Pessoa("Sidney", valorEsperado, "11/10/2021");
        var valorAtual = pessoa.GetCpf();
        Assert.Equal(valorEsperado, valorAtual);
    }
    [Fact]
    public void TesteFuncionalidadeDeGetSetDataDeNascimento()
    {
        var valorEsperado = "10/11/1988";
        var pessoa = new Pessoa("Sidney", "55454887", valorEsperado);
        var valorAtual = pessoa.GetDataDeNascimento();
        Assert.Equal(valorEsperado, valorAtual);
    }
}