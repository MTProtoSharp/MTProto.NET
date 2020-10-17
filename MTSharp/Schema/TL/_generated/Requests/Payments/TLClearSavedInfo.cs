using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Payments
{
    [MTObject(0xd83d70c1)]
    public class TLClearSavedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd83d70c1;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Credentials { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Info { get; set; }


    }
}
