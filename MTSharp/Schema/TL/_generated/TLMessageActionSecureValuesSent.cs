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
    [MTObject(0xd95c6154)]
    public class TLMessageActionSecureValuesSent : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0xd95c6154;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsSecureValueType> Types { get; set; }


    }
}
