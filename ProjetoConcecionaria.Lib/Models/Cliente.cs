using ProjetoConcecionaria.Lib.Exceptions;
using ProjetoConcecionaria.Lib.Models;

namespace ProjetoConcecionaria.Lib.Models
{
    public class Cliente : Pessoa
    {
        private string Telefone { get; set; }
        private string Email { get; set; }
        public Cliente(string telefone, string email, string nome, string cpf, 
        DateTime dataDeNascimento): base(nome, cpf, dataDeNascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }
        public void SetTelefone(string telefone)
        {
            ValidarTelefone(telefone);
            Telefone = telefone;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public void SetEmail(string email)
        {
            ValidarEmail(email);
            Email = email;
        }
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            throw new ErroDeValidacaoException("Erro! Email deve conter @.");
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
            throw new ErroDeValidacaoException("Erro! Telefone não pode ser menor que 8 e maior que 15.");
        }
    }
}