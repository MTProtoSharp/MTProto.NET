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

namespace MTSharp.Schema.TL.Auth
{
    [MTObject(0x741cd3e3)]
    public class TLCodeTypeCall : TLAbsCodeType
    {
        public override uint Constructor
        {
            get
            {
                return 0x741cd3e3;
            }
        }



    }
}
