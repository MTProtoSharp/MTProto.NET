using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x9a422c20)]
    public class TLUpdateRecentStickers : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x9a422c20;
            }
        }



    }
}
