using ConcecionariaDoDev.Controllers.MinhasExceptions;
namespace ConcecionariaDoDev
{
    public class Carro : Veiculo
    {
        private bool TransmissaoAutomatica { get; set; }
        private string Combustivel { get; set; }
        public Carro(bool transmissaoAutomatica, string combustivel, 
        string marca, string modelo, DateTime ano, string quilometragem, string cor, double valor)
        : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetTransmissaoAutomatica(transmissaoAutomatica);
            SetCombustivel(combustivel);
        }
        public void SetTransmissaoAutomatica(bool transmissaoAutomatica)
        {
            TransmissaoAutomatica = transmissaoAutomatica;
        }
        public bool GetTransmissaoAutomatica()
        {
            return TransmissaoAutomatica;
        }
        public void SetCombustivel(string combustivel)
        {
            Combustivel = combustivel;
        }
        public string GetCombustivel()
        {
            return Combustivel;
        }
        public void CalcularValor()
        {
            if (TransmissaoAutomatica)
            {
                Valor = Valor * 1.2;
            }
        }

        public override bool ValidarValorVeiculo(double valor)
        {
            if (valor > 5000)
            {
                return true;
            }
            throw new InputIncorreto("Erro! O valor da moto não pode ser menor que 5000.");
        }
    }
}
//- Para Carro: Carros automáticos são +20% mais caros.