using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0xdf77f3bc)]
    public class TLResetAuthorization : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xdf77f3bc;
            }
        }

        [MTParameter(Order = 0)]
        public long Hash { get; set; }


    }
}
