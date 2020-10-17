using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xf7444763)]
    public class TLJsonArray : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0xf7444763;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsJSONValue> Value { get; set; }


    }
}
