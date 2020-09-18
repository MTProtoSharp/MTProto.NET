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

namespace MTSharp.Schema.TL.Requests.Channels
{
    [MTObject(0x8f38cd1f)]
    public class TLEditCreator : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8f38cd1f;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputChannel Channel { get; set; }
		[MTParameter(Order = 1)]
		public TLAbsInputUser UserId { get; set; }
		[MTParameter(Order = 2)]
		public TLAbsInputCheckPasswordSRP Password { get; set; }


    }
}
