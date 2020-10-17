using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x98f6ac75)]
    public class TLPromoDataEmpty : TLAbsPromoData
    {
        public override uint Constructor
        {
            get
            {
                return 0x98f6ac75;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }


    }
}
