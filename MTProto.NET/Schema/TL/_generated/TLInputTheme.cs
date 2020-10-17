using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x3c5693e9)]
    public class TLInputTheme : TLAbsInputTheme
    {
        public override uint Constructor
        {
            get
            {
                return 0x3c5693e9;
            }
        }

        [MTParameter(Order = 0)]
        public long Id { get; set; }
        [MTParameter(Order = 1)]
        public long AccessHash { get; set; }


    }
}
