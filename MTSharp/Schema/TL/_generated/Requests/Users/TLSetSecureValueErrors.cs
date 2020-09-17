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

namespace MTSharp.Schema.TL.Requests.Users
{
    [MTObject(0x90c894b5)]
    public class TLSetSecureValueErrors : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x90c894b5;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser Id { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsSecureValueError> Errors { get; set; }


    }
}
