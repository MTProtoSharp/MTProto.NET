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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0x560f8935)]
    public class TLSentEncryptedMessage : TLAbsSentEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x560f8935;
            }
        }

		[MTParameter(Order = 0)]
		public int Date { get; set; }


    }
}
