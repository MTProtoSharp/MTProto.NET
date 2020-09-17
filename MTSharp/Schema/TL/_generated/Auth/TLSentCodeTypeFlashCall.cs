using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0xab03c6d9)]
    public class TLSentCodeTypeFlashCall : TLAbsSentCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0xab03c6d9;
            }
        }

        [MTParameter(Order = 0)]
        public string Pattern { get; set; }


    }
}
