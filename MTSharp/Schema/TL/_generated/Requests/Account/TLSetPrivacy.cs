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

namespace MTSharp.Schema.TL.Requests.Account
{
    [MTObject(0xc9f81ce8)]
    public class TLSetPrivacy : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc9f81ce8;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPrivacyKey Key { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsInputPrivacyRule> Rules { get; set; }


    }
}
