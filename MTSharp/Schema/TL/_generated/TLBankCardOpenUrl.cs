using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf568028a)]
    public class TLBankCardOpenUrl : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf568028a;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public string Name { get; set; }


    }
}
