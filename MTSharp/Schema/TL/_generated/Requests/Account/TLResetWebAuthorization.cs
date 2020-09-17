using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x2d01b9ef)]
    public class TLResetWebAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2d01b9ef;
            }
        }

        [MTParameter(Order = 0)]
        public long Hash { get; set; }


    }
}
