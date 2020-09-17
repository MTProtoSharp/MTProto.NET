using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x92d33a0e)]
    public class TLUrlAuthResultRequest : TLAbsUrlAuthResult
    {
        public override uint Constructor
        {
            get
            {
                return 0x92d33a0e;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool RequestWriteAccess { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsUser Bot { get; set; }
        [MTParameter(Order = 3)]
        public string Domain { get; set; }


    }
}
