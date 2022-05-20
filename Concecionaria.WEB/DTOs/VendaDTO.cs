using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;

namespace Concecionaria.WEB.DTOs
{
    public class VendaDTO 
    {
        public Cliente Comprador { get; set; }
        public Funcionario Vendedor { get; set; }
        public Veiculo Veiculo { get; set; }
        public string FormaDePagamento { get; set; }
        public double ValorFinal { get; set; } 
    }
}