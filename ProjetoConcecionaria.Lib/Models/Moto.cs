using ProjetoConcecionaria.Lib.Exceptions;

namespace ProjetoConcecionaria.Lib.Models
{
    public class Moto : Veiculo
    {
        private int Cilindrada { get; set; }
        private string Partida { get; set; }
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
        public override bool ValidarValorVeiculo(double valor)
        {
            if (valor > 2000)
            {
                return true;
            }
            throw new ErroDeValidacaoException("Erro! O valor da moto não pode ser menor que 2000.");
        }

    }
}