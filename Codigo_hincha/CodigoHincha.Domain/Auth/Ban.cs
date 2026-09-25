using CodigoHincha.Domain.Post;

namespace CodigoHincha.Domain.Auth;

public class Ban
{
    private long idBan;
    public long IdBan { get => idBan; set => idBan = value; }
    private long idUser;
    public long IdUser { get => idUser; set => idUser = value; }
    private long? idPost;
    public long? IdPost { get => idPost; set => idPost = value; }

    private DateTime startDate;
    public DateTime StartDate { get => startDate; set => startDate = value; }

    private DateTime endDate;
    public DateTime EndDate { get => endDate; set => endDate = value; }

    private string reason = string.Empty;
    public string Reason { get => reason; set => reason = value; }


}