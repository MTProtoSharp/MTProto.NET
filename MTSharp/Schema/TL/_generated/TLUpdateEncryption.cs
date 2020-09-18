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
    [MTObject(0xb4a2e88d)]
    public class TLUpdateEncryption : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4a2e88d;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsEncryptedChat Chat { get; set; }
		[MTParameter(Order = 1)]
		public int Date { get; set; }


    }
}
