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

namespace MTSharp.Schema.TL.Storage
{
    [MTObject(0x528a0677)]
    public class TLFileMp3 : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0x528a0677;
            }
        }



    }
}
