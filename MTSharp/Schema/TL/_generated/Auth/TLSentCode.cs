using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x5e002502)]
    public class TLSentCode : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5e002502;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public Auth.TLAbsSentCodeType Type { get; set; }
        [MTParameter(Order = 2)]
        public string PhoneCodeHash { get; set; }
        [MTParameter(Order = 3, FlagBitId = 1, FlagType = FlagType.Null)]
        public Auth.TLAbsCodeType NextType { get; set; }
        [MTParameter(Order = 4, FlagBitId = 2, FlagType = FlagType.Null)]
        public int? Timeout { get; set; }


    }
}
