namespace CodigoHincha.Domain.Auth;

public class User
{
    private long id;

    public global::System.Int64 Id { get => id; set => id = value; }
    private string userName = "";

    public global::System.String UserName { get => userName; set => userName = value; }

    private string password ="";

    public global::System.String Password { get => password; set => password = value; }

    private Image?  image= null;
    public virtual Image Image { get => image; set => image = value; }



}