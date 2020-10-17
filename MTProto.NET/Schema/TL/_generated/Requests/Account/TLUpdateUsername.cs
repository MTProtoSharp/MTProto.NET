using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x3e0bdd7c)]
    public class TLUpdateUsername : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x3e0bdd7c;
            }
        }

        [MTParameter(Order = 0)]
        public string Username { get; set; }


    }
}
