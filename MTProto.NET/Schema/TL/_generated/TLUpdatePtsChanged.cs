using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3354678f)]
    public class TLUpdatePtsChanged : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x3354678f;
            }
        }



    }
}
