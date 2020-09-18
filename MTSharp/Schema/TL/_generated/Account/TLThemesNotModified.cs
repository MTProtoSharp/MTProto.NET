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

namespace MTSharp.Schema.TL.Account
{
    [MTObject(0xf41eb622)]
    public class TLThemesNotModified : TLAbsThemes
    {
        public override uint Constructor
        {
            get
            {
                return 0xf41eb622;
            }
        }



    }
}
