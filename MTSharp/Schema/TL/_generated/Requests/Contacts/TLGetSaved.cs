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
    [MTObject(0x82f1e39f)]
    public class TLGetSaved : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x82f1e39f;
            }
        }



    }
}
