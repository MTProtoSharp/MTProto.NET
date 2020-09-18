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
    [MTObject(0xbfb9f457)]
    public class TLPassportConfigNotModified : TLAbsPassportConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0xbfb9f457;
            }
        }



    }
}
