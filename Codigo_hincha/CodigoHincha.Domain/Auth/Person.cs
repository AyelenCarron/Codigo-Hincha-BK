using CodigoHincha.Domain.FileSystem;

namespace CodigoHincha.Domain.Auth;

public class Person
{
    private long idPerson;

    public long IdPerson { get => idPerson; set => idPerson = value; }
    private string nombre = "";
    public string Nombre { get => nombre; set => nombre = value; }

    private string lastName = "";
    public string LastName { get => lastName; set => lastName = value; }
    private string email = "";
    public string Email { get => email; set => email = value; }

}
