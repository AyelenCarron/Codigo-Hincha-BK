

namespace CodigoHincha.Domain.Auth;

public class User
{
    private long id;

    public long Id { get => id; set => id = value; }
    private string userName = "";
    public String UserName { get => userName; set => userName = value; }

    private string password ="";

    public string Password { get => password; set => password = value; }
    private Image? image = null;
    public virtual Image? Image { get => image; set => image = value; }

}