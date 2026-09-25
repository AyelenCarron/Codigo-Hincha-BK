namespace CodigoHincha.Domain.Social;

public class Club
{
    private long idClub;
    public long IdClub { get => idClub; set => idClub = value; }

    private string nameClub = "";
    public string NameClub { get => nameClub; set => nameClub = value; }

    private string league = "";
    public string League { get => league; set => league = value; }
}