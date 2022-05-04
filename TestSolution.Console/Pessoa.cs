namespace ConcecionariaDoDev;

public class Pessoa
{
    private string Nome { get; set; }
    private string Cpf { get; set; }
    private DateTime DataDeNascimento { get; set; }

    public Pessoa(string nome, string cpf, DateTime dataDeNascimento)
    {
        Nome = nome;
        Cpf = cpf;
        DataDeNascimento = dataDeNascimento;

    }
    public void SetNome(string nome)
    {
        Nome = nome;
    }
    public string GetNome()
    {
        return Nome;
    }
    public void SetCpf(string cpf)
    {
        Cpf = cpf;
    }
    public string GetCpf()
    {
        return Cpf;
    }
    public void SetDataDeNascimento(DateTime dataDeNascimento)
    {
        DataDeNascimento = dataDeNascimento;
    }
    public DateTime GetDataDeNascimento()
    {
        return DataDeNascimento;
    }
}