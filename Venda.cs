namespace ConcecionariaDoDev

{
    public class Venda 
    {
        private Cliente Comprador { get; set; }
        private Funcionario Vendedor { get; set; }
        private Veiculo Veiculo { get; set; }
        private string FormaDePagamento { get; set; }
        private double ValorFinal { get; set; }

        public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formaDePagamento, double valorFinal)
        {
            Comprador = comprador;
            Vendedor = vendedor;
            Veiculo = veiculo;
            FormaDePagamento = formaDePagamento;
            ValorFinal = valorFinal;
        }

        public void SetComprador(Cliente comprador)
        {
            Comprador = comprador;
        }
        public string GetComprador()
        {
            return Comprador; ;
        }
        public void SetVendedor(Funcionario vendedor)
        {
            Vendedor = vendedor;
        }
        public string GetVendedor()
        {
            return Vendedor;
        }
        public void SetVeiculo(Veiculo veiculo)
        {
            Veiculo = veiculo;
        }
        public string GetVeiculo()
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
    }
}