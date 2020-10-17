using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x2be0dfa4)]
    public class TLJsonNumber : TLAbsJSONValue
    {
        public override uint Constructor
        {
            get
            {
                return 0x2be0dfa4;
            }
        }

        [MTParameter(Order = 0)]
        public double Value { get; set; }


    }
}
