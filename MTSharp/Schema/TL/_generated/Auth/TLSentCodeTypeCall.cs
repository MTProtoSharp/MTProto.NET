using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x5353e5a7)]
    public class TLSentCodeTypeCall : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0x5353e5a7;
            }
        }

        [MTParameter(Order = 0)]
        public int Length { get; set; }


    }
}
