using ProjetoConcecionaria.Lib.Exceptions;
using ProjetoConcecionaria.Lib.Models;

namespace ProjetoConcecionaria.Lib.Models
{
    public class Venda
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        protected string FormaDePagamento { get; set; }
        protected double ValorFinal { get; set; }
        public int IdVenda {get; set;}
        public int IdFuncionario {get; set;}
        public virtual Carro Carro {get; set;}
        public virtual Moto Moto {get; set;}
        
        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaDePagamento, double valorFinal)
        {
            SetComprador(comprador);
            SetVendedor(vendedor);
            SetVeiculo(veiculo);
            SetFormaDePagamento(formaDePagamento);
            SetValorFinal(valorFinal);
        }

        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }
        public Cliente GetComprador()
        {
            return Comprador;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }
        public Funcionario GetVendedor()
        {
            return Vendedor;
        }
        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }
        public Veiculo GetVeiculo()
        {
            return Veiculo;
        }
        public void SetFormaDePagamento(string formaDePagamento)
        {
            FormaDePagamento = formaDePagamento;
        }
        public string GetFormaDePagamento()
        {
            return FormaDePagamento;
        }
        public void SetValorFinal(double valorFinal)
        {
            ValorFinal = valorFinal;
        }
        public double GetValorFinal()
        {
            return ValorFinal;
        }
        public void AplicarDesconto()
        {
            if (Vendedor.GetCargo() == "Gerente")
            {
                ValorFinal = ValorFinal * 0.95;
            }
        }
    }
}