using CodigoHincha.Domain.FileSystem;

namespace CodigoHincha.Domain.Auth;

public class User: Person
{
    private long idUser;

    public long IdUser  { get => idUser; set => idUser = value; }
    private string userName = "";
    public String UserName { get => userName; set => userName = value; }

    private string password ="";

    public string Password { get => password; set => password = value; }
    private Image? image = null;
    public virtual Image? Image { get => image; set => image = value; }

    private DateOnly registrationDate;
    public DateOnly RegistrationDate { get => registrationDate; set => registrationDate = value; }

    private UserRol rol = UserRol.User;
    public UserRol Rol { get => rol; set => rol = value; }


}