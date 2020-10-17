using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Updates
{
    [MTObject(0x4afe8f6d)]
    public class TLDifferenceTooLong : TLAbsDifference
    {
        public override uint Constructor
        {
            get
            {
                return 0x4afe8f6d;
            }
        }

        [MTParameter(Order = 0)]
        public int Pts { get; set; }


    }
}
