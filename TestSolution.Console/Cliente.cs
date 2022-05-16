using ConcecionariaDoDev.Controllers.MinhasExceptions;

namespace ConcecionariaDoDev
{

    public class Cliente : Pessoa
    {
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(string email, string telefone,
         string nome, string cpf, string dataDeNascimento)
        : base(nome, cpf, dataDeNascimento)
        {
            SetEmail(email);
            SetCpf(cpf);
            SetTelefone(telefone);
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
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            return false;
            throw new InputIncorreto("Erro grave!");
        }
        public string GetEmail()
        {
            return Email;
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length > 8 && telefone.Length < 15)
            {
                return true;
            }
            return false;
            throw new InputIncorreto("Erro grave!");
        }
    }
}