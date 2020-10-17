using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0x78515775)]
    public class TLUpdateProfile : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x78515775;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FlagBitId = 0, FlagType = FlagType.Null)]
        public string FirstName { get; set; }
        [MTParameter(Order = 2, FlagBitId = 1, FlagType = FlagType.Null)]
        public string LastName { get; set; }
        [MTParameter(Order = 3, FlagBitId = 2, FlagType = FlagType.Null)]
        public string About { get; set; }


    }
}
