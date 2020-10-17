using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x26ffde7d)]
    public class TLUpdateDialogFilter : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x26ffde7d;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }
        [MTParameter(Order = 2, FlagBitId = 0, FlagType = FlagType.Null)]
        public MTSharp.Schema.TL.TLDialogFilter Filter { get; set; }


    }
}
