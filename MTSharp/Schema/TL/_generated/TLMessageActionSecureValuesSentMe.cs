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
    [MTObject(0x1b287353)]
    public class TLMessageActionSecureValuesSentMe : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x1b287353;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLSecureValue> Values { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLSecureCredentialsEncrypted Credentials { get; set; }


    }
}
