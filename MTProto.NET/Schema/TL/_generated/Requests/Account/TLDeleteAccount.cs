using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Account
{
    [MTObject(0x418d4e0b)]
    public class TLDeleteAccount : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x418d4e0b;
            }
        }

        [MTParameter(Order = 0)]
        public string Reason { get; set; }


    }
}
