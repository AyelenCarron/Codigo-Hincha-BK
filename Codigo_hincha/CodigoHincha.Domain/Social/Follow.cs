using System.Runtime.InteropServices.Marshalling;
using CodigoHincha.Domain.Auth;

namespace CodigoHincha.Domain.Social;

public class Follow
{
    private long idFollow;
    public long IdFollow { get => idFollow; set => idFollow = value; }

    private User? follower;
    public virtual User? Follower { get => follower; set => follower = value; }
    
    private User? following;
    public virtual User? Following { get => following; set => following = value; }

}

