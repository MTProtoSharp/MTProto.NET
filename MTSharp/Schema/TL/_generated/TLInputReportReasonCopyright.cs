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
    [MTObject(0x9b89f93a)]
    public class TLInputReportReasonCopyright : TLAbsReportReason
    {
        public override uint Constructor
        {
            get
            {
                return 0x9b89f93a;
            }
        }



    }
}
