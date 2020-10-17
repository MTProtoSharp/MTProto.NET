using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb71e767a)]
    public class TLJsonString : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0xb71e767a;
            }
        }

        [MTParameter(Order = 0)]
        public string Value { get; set; }


    }
}
