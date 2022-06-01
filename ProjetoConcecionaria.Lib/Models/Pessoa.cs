
using ProjetoConcecionaria.Lib.Exceptions;
namespace ProjetoConcecionaria.Lib.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private DateTime DataDeNascimento { get; set; }
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
}