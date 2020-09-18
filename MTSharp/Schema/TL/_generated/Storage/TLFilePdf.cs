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
    [MTObject(0xae1e508d)]
    public class TLFilePdf : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0xae1e508d;
            }
        }



    }
}
