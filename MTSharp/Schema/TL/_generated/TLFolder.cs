using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xff544e65)]
    public class TLFolder : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xff544e65;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.True)]
        public bool AutofillNewBroadcasts { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.True)]
        public bool AutofillPublicGroups { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.True)]
        public bool AutofillNewCorrespondents { get; set; }
        [MTParameter(Order = 4)]
        public int Id { get; set; }
        [MTParameter(Order = 5)]
        public string Title { get; set; }
        [MTParameter(Order = 6, FlagBitId = 3, FlagType = FlagType.Null)]
        public TLAbsChatPhoto Photo { get; set; }


    }
}
