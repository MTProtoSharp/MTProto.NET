using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0x18d1cdc2)]
    public class TLBotInlineMessageMediaContact : TLAbsBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x18d1cdc2;
            }
        }

        [MTParameter(Order = 0, IsFlag = true)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 2)]
        public string FirstName { get; set; }
        [MTParameter(Order = 3)]
        public string LastName { get; set; }
        [MTParameter(Order = 4)]
        public string Vcard { get; set; }
        [MTParameter(Order = 5, FlagBitId = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
