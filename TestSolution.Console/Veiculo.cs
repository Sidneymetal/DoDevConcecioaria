using ConcecionariaDoDev.Controllers.MinhasExceptions;

namespace ConcecionariaDoDev
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public string Quilometragem { get; set; }
        public string Cor { get; set; }
        public double Valor { get; set; }
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
        public bool ValidarAno(DateTime ano)
        {
            if (ano > DateTime.Parse("01/01/2004") && ano < DateTime.Now)
            {
                return true;
            }
            return false;
            throw new InputIncorreto("Erro grave!");
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