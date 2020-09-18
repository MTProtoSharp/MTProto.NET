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

namespace MTSharp.Schema.TL.Contacts
{
    [MTObject(0xb52c939d)]
    public class TLTopPeersDisabled : TLAbsTopPeers
    {
        public override uint Constructor
        {
            get
            {
                return 0xb52c939d;
            }
        }



    }
}
