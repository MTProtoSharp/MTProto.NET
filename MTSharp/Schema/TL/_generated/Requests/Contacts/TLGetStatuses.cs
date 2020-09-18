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

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xc4a353ee)]
    public class TLGetStatuses : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc4a353ee;
            }
        }



    }
}
