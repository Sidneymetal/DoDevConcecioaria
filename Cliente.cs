namespace ConcecionariaDoDev;

class Cliente : Pessoa
{
    private string Telefone { get; set; }
    private string Email { get; set; }

    public Cliente(string email, string telefone,
     string nome, string cpf, DateTime dataDeNascimento)
    : base(nome, cpf, dataDeNascimento)
    {
        Email = email;
        Telefone = telefone;
    }
    public void SetTelefone(string telefone)
    {
        Telefone = telefone;
    }
    public string GetTelefone()
    {
        return Telefone;
    }
    public void SetEmail(string email)
    {
        Email = email;
    }
    public string GetEmail()
    {
        return Email;
    }

}