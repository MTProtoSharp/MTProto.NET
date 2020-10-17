using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3f6d7b68)]
    public class TLJsonNull : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0x3f6d7b68;
            }
        }



    }
}
