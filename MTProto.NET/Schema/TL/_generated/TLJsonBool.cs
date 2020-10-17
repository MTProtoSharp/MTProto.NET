using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc7345e6a)]
    public class TLJsonBool : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7345e6a;
            }
        }

        [MTParameter(Order = 0)]
        public bool Value { get; set; }


    }
}
