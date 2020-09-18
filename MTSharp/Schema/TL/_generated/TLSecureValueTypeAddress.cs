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
    [MTObject(0xcbe31e26)]
    public class TLSecureValueTypeAddress : TLAbsSecureValueType
    {
        public override uint Constructor
        {
            get
            {
                return 0xcbe31e26;
            }
        }



    }
}
