using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xe844ebff)]
    public class TLSearchCounter : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe844ebff;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 1, FlagType = FlagType.True)]
        public bool Inexact { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsMessagesFilter Filter { get; set; }
        [MTParameter(Order = 3)]
        public int Count { get; set; }


    }
}
