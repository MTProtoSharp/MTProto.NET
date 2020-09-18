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

namespace MTSharp.Schema.TL.Requests.Auth
{
    [MTObject(0xcdd42a05)]
    public class TLBindTempAuthKey : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcdd42a05;
            }
        }

		[MTParameter(Order = 0)]
		public long PermAuthKeyId { get; set; }
		[MTParameter(Order = 1)]
		public long Nonce { get; set; }
		[MTParameter(Order = 2)]
		public int ExpiresAt { get; set; }
		[MTParameter(Order = 3)]
		public byte[] EncryptedMessage { get; set; }


    }
}
