using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x99c1d49d)]
    public class TLJsonObject : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0x99c1d49d;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTProto.NET.Schema.TL.TLJsonObjectValue> Value { get; set; }


    }
}
