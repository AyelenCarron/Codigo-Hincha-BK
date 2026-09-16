using System.Runtime.InteropSservices.Marshalling;
using CodigoHincha.Domain.Auth

namespace CodigoHincha.Domain.Social;

public class follow
{
    private long id;
    public global::System.Int64 Id { get => id; set => id = value; }
    public User Follower { get => follower; set => follower = value; }

    private User? follower;
        public User Follower { get => follower; set => follower = value; }
    public user Following { get => Following1; set => Following1 = value; }
    
    private user? following;
    public user Following1 { get => following; set => following = value; }

}

