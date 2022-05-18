namespace ConcecionariaDoDev
{
    public class Funcionario : Pessoa
    {
        protected string Cargo { get; set; }
        public Funcionario(string cargo, string nome,
        string cpf, DateTime dataDeNascimento)
        : base(nome, cpf, dataDeNascimento)
        {
            Cargo = cargo;
        }
        public void SetCargo(string cargo)
        {
            Cargo = cargo;
        }
        public string GetCargo()
        {
            return Cargo;
        }
    }
}