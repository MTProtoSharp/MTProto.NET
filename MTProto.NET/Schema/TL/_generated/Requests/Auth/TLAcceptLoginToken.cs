using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0xe894ad4d)]
    public class TLAcceptLoginToken : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe894ad4d;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Token { get; set; }


    }
}
