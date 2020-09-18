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

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0x38a08d3)]
    public class TLGetUserInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x38a08d3;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputUser UserId { get; set; }


    }
}
