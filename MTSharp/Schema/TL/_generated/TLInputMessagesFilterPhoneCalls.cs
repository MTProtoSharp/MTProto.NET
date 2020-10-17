using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x80c99768)]
    public class TLInputMessagesFilterPhoneCalls : TLAbsMessagesFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0x80c99768;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool Missed { get; set; }


    }
}
