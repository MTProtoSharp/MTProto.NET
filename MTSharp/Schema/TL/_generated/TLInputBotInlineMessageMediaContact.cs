using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL
{
    [MTObject(0xa6edbffd)]
    public class TLInputBotInlineMessageMediaContact : TLAbsInputBotInlineMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0xa6edbffd;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 2)]
        public string FirstName { get; set; }
        [MTParameter(Order = 3)]
        public string LastName { get; set; }
        [MTParameter(Order = 4)]
        public string Vcard { get; set; }
        [MTParameter(Order = 5, FromFlag = 2, FlagType = FlagType.Null)]
        public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
