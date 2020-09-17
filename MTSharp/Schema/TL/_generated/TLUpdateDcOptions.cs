using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x8e5e9873)]
    public class TLUpdateDcOptions : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x8e5e9873;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLDcOption> DcOptions { get; set; }


    }
}
