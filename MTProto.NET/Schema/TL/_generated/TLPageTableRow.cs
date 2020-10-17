using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xe0c0c5e5)]
    public class TLPageTableRow : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe0c0c5e5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLPageTableCell> Cells { get; set; }


    }
}
