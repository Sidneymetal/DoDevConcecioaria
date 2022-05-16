namespace ConcecionariaDoDev
{
    public class Carro : Veiculo
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
        public Carro()
        {
            
        }
        public Carro(bool transmissaoAutomatica, string combustivel, string marca, string modelo, DateTime ano, string quilometragem, string cor, double valor)
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
        
    }
}
//- Para Carro: Carros automáticos são +20% mais caros.