using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Auth
{
    [MTObject(0x3dbb5986)]
    public class TLSentCodeTypeApp : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0x3dbb5986;
            }
        }

        [MTParameter(Order = 0)]
        public int Length { get; set; }


    }
}
