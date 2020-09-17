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

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool AutofillNewBroadcasts { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool AutofillPublicGroups { get; set; }
        [MTParameter(Order = 3, FromFlag = 2, FlagType = FlagType.True)]
        public bool AutofillNewCorrespondents { get; set; }
        [MTParameter(Order = 4)]
        public int Id { get; set; }
        [MTParameter(Order = 5)]
        public string Title { get; set; }
        [MTParameter(Order = 6, FromFlag = 3, FlagType = FlagType.Null)]
        public TLAbsChatPhoto Photo { get; set; }


    }
}
