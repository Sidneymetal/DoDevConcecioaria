namespace ConcecionariaDoDev;

class Carro : Veiculo
{
    private bool TransmissaoAutomatica { get; set; }
    private string Combustivel { get; set; }
    public Carro(bool transmissaoAutomatica, string combustivel, string marca, string modelo, DateTime ano, string quilometragem, string cor, double valor)
    : base(marca, modelo, ano, quilometragem, cor, valor)
    {
        TransmissaoAutomatica = transmissaoAutomatica;
        Combustivel = combustivel;
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
}

