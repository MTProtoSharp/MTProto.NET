using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Account
{
    [MTObject(0x811f854f)]
    public class TLSentEmailCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x811f854f;
            }
        }

        [MTParameter(Order = 0)]
        public string EmailPattern { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }


    }
}
