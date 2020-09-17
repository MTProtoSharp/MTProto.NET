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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xf64daf43)]
    public class TLRequestEncryption : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf64daf43;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 1)]
		public int RandomId { get; set; }
		[MTParameter(Order = 2)]
		public byte[] GA { get; set; }


    }
}
