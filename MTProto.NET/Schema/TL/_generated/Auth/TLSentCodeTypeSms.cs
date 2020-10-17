using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Auth
{
    [MTObject(0xc000bba2)]
    public class TLSentCodeTypeSms : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0xc000bba2;
            }
        }

        [MTParameter(Order = 0)]
        public int Length { get; set; }


    }
}
