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
    [MTObject(0xf888fa1a)]
    public class TLPrivacyValueDisallowContacts : TLAbsPrivacyRule
    {
        public override uint Constructor
        {
            get
            {
                return 0xf888fa1a;
            }
        }



    }
}
