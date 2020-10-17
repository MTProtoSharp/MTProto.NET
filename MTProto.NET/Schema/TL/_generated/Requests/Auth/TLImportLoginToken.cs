using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x95ac5ce4)]
    public class TLImportLoginToken : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x95ac5ce4;
            }
        }

        [MTParameter(Order = 0)]
        public byte[] Token { get; set; }


    }
}
