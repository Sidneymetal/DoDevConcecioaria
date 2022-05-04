namespace ConcecionariaDoDev
{

    public class Cliente : Pessoa
    {
        private string Telefone { get; set; }
        private string Email { get; set; }

        public Cliente(string email, string telefone,
         string nome, string cpf, DateTime dataDeNascimento)
        : base(nome, cpf, dataDeNascimento)
        {
            SetEmail(email);
            SetCpf(cpf);
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
}