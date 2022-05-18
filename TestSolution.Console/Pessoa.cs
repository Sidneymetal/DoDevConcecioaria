namespace ConcecionariaDoDev;

public class Pessoa
{
    protected string Nome { get; set; }
    protected string Cpf { get; set; }
    protected DateTime DataDeNascimento { get; set; }
    public Pessoa(string nome, string cpf, DateTime dataDeNascimento)
    {
        SetNome(nome);
        SetCpf(cpf);
        SetDataDeNascimento(dataDeNascimento);

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