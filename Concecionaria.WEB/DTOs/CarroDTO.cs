namespace Concecionaria.WEB.DTOs
{
    public class CarroDTO : VeiculoDTO
    {
        public bool TransmissaoAutomatica { get; set; }
        public string Combustivel { get; set; }
    }
}