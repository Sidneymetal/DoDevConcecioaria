using ProjetoConcecionaria.Lib.Models;
namespace ProjetoConcecionaria.Lib.Exceptions
{
    public class ErroDeValidacaoException : Exception
    {
        public ErroDeValidacaoException()
        {

        }
        public ErroDeValidacaoException(string message) : base(message)
        {
            
        }
    }


}