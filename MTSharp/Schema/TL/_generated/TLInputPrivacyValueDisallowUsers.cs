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
    [MTObject(0x90110467)]
    public class TLInputPrivacyValueDisallowUsers : TLAbsInputPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0x90110467;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<TLAbsInputUser> Users { get; set; }


    }
}
