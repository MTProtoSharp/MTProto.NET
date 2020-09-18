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
    [MTObject(0xa4f63c0)]
    public class TLFilePng : TLAbsFileType
    {
        public override uint Constructor
        {
            get
            {
                return 0xa4f63c0;
            }
        }



    }
}
