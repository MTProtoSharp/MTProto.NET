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
    [MTObject(0xee3b272a)]
    public class TLUpdatePrivacy : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xee3b272a;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsPrivacyKey Key { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<TLAbsPrivacyRule> Rules { get; set; }


    }
}
