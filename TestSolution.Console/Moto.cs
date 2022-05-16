namespace ConcecionariaDoDev

{

    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Partida { get; set; }
        public Moto()
        {
            
        }
        public Moto(int cilindrada, string partida, string marca, string modelo,
         DateTime ano, string quilometragem, string cor, double valor)
        : base(marca, modelo, ano, quilometragem, cor, valor)
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
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
        public void CalcularCilindrada()
        {
            var valorCilindrada = (Cilindrada * 50);
            Valor = Valor + valorCilindrada;
            if (Partida == "Eletrônica")
            {
                Valor = Valor * 1.1;
            }
        }

    }
}
//- Para Motos: (Cilindradas * 50) + 10% do valor se a partida for injeção eletrônica.
