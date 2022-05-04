namespace ConcecionariaDoDev
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private string Quilometragem { get; set; }
        private string Cor { get; set; }
        protected double Valor { get; set; }
        public Veiculo(string marca, string modelo, DateTime ano, string quilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetQuilometragem(quilometragem);
            SetCor(cor);
            SetValor(valor);
        }


        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetAno(DateTime ano)
        {
            Ano = ano;
        }
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetQuilometragem(string quilometragem)
        {
            Quilometragem = quilometragem;
        }
        public string GetQuilometragem()
        {
            return Quilometragem;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }
        public string GetCor()
        {
            return Cor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public double GetValor()
        {
            return Valor;
        }

    }
}