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
    [MTObject(0x9493ff32)]
    public class TLSentEncryptedFile : TLAbsSentEncryptedMessage
    {
        public override uint Constructor
        {
            get
            {
                return 0x9493ff32;
            }
        }

		[MTParameter(Order = 0)]
		public int Date { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsEncryptedFile File { get; set; }


    }
}
