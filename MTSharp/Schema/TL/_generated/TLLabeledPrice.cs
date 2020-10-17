using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcb296bf8)]
    public class TLLabeledPrice : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcb296bf8;
            }
        }

        [MTParameter(Order = 0)]
        public string Label { get; set; }
        [MTParameter(Order = 1)]
        public long Amount { get; set; }


    }
}
