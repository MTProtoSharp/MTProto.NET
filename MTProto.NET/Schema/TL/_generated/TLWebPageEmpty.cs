using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xeb1477e8)]
    public class TLWebPageEmpty : TLAbsWebPage
    {
        public override uint Constructor
        {
            get
            {
                return 0xeb1477e8;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }


    }
}
