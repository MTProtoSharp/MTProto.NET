using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x56022f4d)]
    public class TLUpdateLangPack : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x56022f4d;
            }
        }

        [MTParameter(Order = 0)]
        public MTSharp.Schema.TL.TLLangPackDifference Difference { get; set; }


    }
}
