using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0xf8b036af)]
    public class TLGetAdminedPublicChannels : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf8b036af;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool ByLocation { get; set; }
        [MTParameter(Order = 2, FromFlag = 1, FlagType = FlagType.True)]
        public bool CheckLimit { get; set; }


    }
}
