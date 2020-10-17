using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x8216fba3)]
    public class TLUpdateTheme : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x8216fba3;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLTheme Theme { get; set; }


    }
}
