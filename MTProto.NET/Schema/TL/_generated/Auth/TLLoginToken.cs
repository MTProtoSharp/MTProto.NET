using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Auth
{
    [MTObject(0x629f1980)]
    public class TLLoginToken : TLAbsLoginToken
    {
        public override uint Constructor
        {
            get
            {
                return 0x629f1980;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }
        [MTParameter(Order = 1)]
        public byte[] Token { get; set; }


    }
}
