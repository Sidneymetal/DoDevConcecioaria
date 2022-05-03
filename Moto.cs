namespace ConcecionariaDoDev;

class Moto : Veiculo
{
    private int Cilindrada { get; set; }
    private string Partida { get; set; }
    public Moto(int cilindrada, string partida, string marca, string modelo,
     DateTime ano, string quilometragem, string cor, double valor)
    : base(marca, modelo, ano, quilometragem, cor, valor)
    {
        Cilindrada = cilindrada;
        Partida = partida;
    }

    public void SetCilindrada(int cilindrada)
    {
        Cilindrada = cilindrada;
    }
    public int GetCilindrada()
    {
        return Cilindrada;
    }
    public void SetPartida(string partida)
    {
        Partida = partida;
    }
    public string GetPartida()
    {
        return Partida;
    }

}