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

namespace MTSharp.Schema.TL.Messages
{
    [MTObject(0xe8025ca2)]
    public class TLSavedGifsNotModified : TLAbsSavedGifs
    {
        public override uint Constructor
        {
            get
            {
                return 0xe8025ca2;
            }
        }



    }
}
