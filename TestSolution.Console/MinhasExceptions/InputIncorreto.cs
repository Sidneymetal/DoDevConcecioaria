namespace ConcecionariaDoDev.Controllers.MinhasExceptions;
public class InputIncorreto : Exception
{
    public InputIncorreto(string msg) : base(msg)
    {

    }
}