namespace ConcecionariaDoDev;

public class Pessoa
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public DateTime DataDeNascimento { get; set; }

    public Pessoa(string nome, string cpf, string dataDeNascimento)
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
    public void SetDataDeNascimento(string dataDeNascimento)
    {
        DataDeNascimento = DateTime.Parse(dataDeNascimento);
    }
    public DateTime GetDataDeNascimento()
    {
        return DataDeNascimento;
    }
}