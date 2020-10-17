using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Photos
{
    [MTObject(0x20212ca8)]
    public class TLPhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x20212ca8;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsPhoto Photo { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
