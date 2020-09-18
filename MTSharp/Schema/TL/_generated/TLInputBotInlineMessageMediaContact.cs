using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

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
		[MTParameter(Order = 5, FlagBitId=2, FlagType= FlagType.Null)]
		public TLAbsReplyMarkup ReplyMarkup { get; set; }


    }
}
