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

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0xc45a6536)]
    public class TLNoAppUpdate : TLAbsAppUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xc45a6536;
            }
        }



    }
}
