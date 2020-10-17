using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc0de1bd9)]
    public class TLJsonObjectValue : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc0de1bd9;
            }
        }

        [MTParameter(Order = 0)]
        public string Key { get; set; }
        [MTParameter(Order = 1)]
        public TLAbsJSONValue Value { get; set; }


    }
}
