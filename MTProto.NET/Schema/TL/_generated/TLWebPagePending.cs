using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc586da1c)]
    public class TLWebPagePending : TLAbsWebPage
    {
        public override uint Constructor
        {
            get
            {
                return 0xc586da1c;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
