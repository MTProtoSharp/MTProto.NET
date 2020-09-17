using MTSharp.Attributes;

namespace MTSharp.Schema.TL
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
        public MTSharp.Schema.TL.TLTheme Theme { get; set; }


    }
}
