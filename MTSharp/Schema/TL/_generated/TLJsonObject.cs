using MTSharp.Attributes;

namespace MTSharp.Schema.TL
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
        public TLVector<MTSharp.Schema.TL.TLJsonObjectValue> Value { get; set; }


    }
}
